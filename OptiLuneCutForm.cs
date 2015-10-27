using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OptiLineCut.src;
using Task = OptiLineCut.src.Task;

namespace OptiLineCut {
  public partial class OptiLuneCutForm : Form {
    private List<OrderPair> order = new List<OrderPair>();
    private double cutThick = 0.05;

    public OptiLuneCutForm() {
      InitializeComponent();
      cmbDimension.SelectedIndex = 0;
      Detail1D det = new Detail1D(pgrdTest, new double[] { 1.0 });
      pgrdTest.SelectedObject = det;
      tbxCutTHick.Text = cutThick.ToString().Replace(',','.');
    }

    private void mnuFileExit_Click(object sender, EventArgs e) {
      Close();
    }

    private void btnCompute_Click(object sender, EventArgs e) {
      try {
        Task task;
        switch(cmbDimension.SelectedIndex){
          case 0:
            task = new Task((Detail1D)pgrdTest.SelectedObject);
            break;
          case 1:
            task = new Task((Detail2D)pgrdTest.SelectedObject);
            break;
          default:
            throw new NotImplementedException("Не реализованный код!");
        }
        task.CutThick = cutThick;
        foreach(OrderPair pair in order)
          task.AddOrder(pair);

        task.Compute();
        fillTable(task);
      }
      catch (Exception ex) {
        MessageBox.Show(ex.Message);
      }

    }

    private void cmbDimension_SelectedIndexChanged(object sender, EventArgs e) {
      Detail det;
      switch (cmbDimension.SelectedIndex) {
        case 0:
          det = new Detail1D(pgrdTest, new double[] { 1.0 });
          break;
        case 1:
          det = new Detail2D(pgrdTest, new double[] { 1.0, 1.0 });
          break;
        default:
          throw new NotImplementedException("Не реализованный код!");
      }
      pgrdTest.SelectedObject = det;
      lbxOrderDetails.Items.Clear();
      pgrdOrderDetail.SelectedObject = null;
      order = new List<OrderPair>();
    }

    private void btnAddOrderDet_Click(object sender, EventArgs e) {
      OrderForm sForm = new OrderForm();
      DialogResult dr = sForm.ShowDialog();

      if (dr != System.Windows.Forms.DialogResult.OK)
        return;

      lbxOrderDetails.Items.Add("Detail_" + lbxOrderDetails.Items.Count.ToString() + "    num:" + sForm.Count.ToString());
      Detail det;
      switch (cmbDimension.SelectedIndex) {
        case 0:
          det = new Detail1D(pgrdOrderDetail, new double[] { 1.0 });
          break;
        case 1:
          det = new Detail2D(pgrdOrderDetail, new double[] { 1.0, 1.0 });
          break;
        default:
          throw new NotImplementedException("Не реализованный код!");
      }
      order.Add(new OrderPair(det, sForm.Count));
    }

    private void lbxOrderDetails_SelectedIndexChanged(object sender, EventArgs e) {
      if (lbxOrderDetails.SelectedIndex == -1) 
        return;

      pgrdOrderDetail.SelectedObject = order[lbxOrderDetails.SelectedIndex].Detail;
    }

    private void tbxCutTHick_TextChanged(object sender, EventArgs e) {
      String value = tbxCutTHick.Text.Replace('.',',');
      try {
        cutThick = Convert.ToDouble(value);
      }
      catch (Exception) {
        MessageBox.Show("Ошибка ввода!");
        tbxCutTHick.Text = cutThick.ToString().Replace(',','.') ;
      }
    }

    private void fillTable(Task task) {
      dgvAllCuts.Rows.Clear();
      dgvAllCuts.Columns.Clear();

      dgvAllCuts.Columns.Add("det", "det");
      dgvAllCuts.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
      for (int i = 0; i < task.AllCuts.Count; i++)
        dgvAllCuts.Columns.Add((i + 1).ToString(), (i + 1).ToString());
      dgvAllCuts.Columns.Add("num", "num");

      String[] str = new String[task.AllCuts.Count + 2];
      str[0] = "det";
      for (int i = 0; i < task.AllCuts.Count; i++)
        str[i + 1] = (i + 1).ToString();
      str[task.AllCuts.Count + 1] = "num";

      dgvAllCuts.Rows.Add(str);
      dgvAllCuts.Rows[0].DefaultCellStyle.BackColor = Color.LightGray;

      OrderPair pair = task.order.First();
      while (pair != null) {
        str[0] = pair.Detail.Volume.ToString();
        str[task.AllCuts.Count + 1] = pair.Num.ToString();

        for (int i = 0; i < task.AllCuts.Count; i++) {
          str[i + 1] = task.AllCuts[i].CountOf(pair.Detail).ToString();
        }
        dgvAllCuts.Rows.Add(str);
        pair = task.GetNextOrderPair(pair);
      }
      String[] str2 = new String[task.AllCuts.Count + 2];
      dgvAllCuts.Rows.Add(str2);
      str[0] = "left";
      str[task.AllCuts.Count + 1] = "";
      for (int i = 0; i < task.AllCuts.Count; i++) {
        str[i + 1] = Math.Round(task.AllCuts[i].Left, 3).ToString();
      }
      dgvAllCuts.Rows.Add(str);
    }
  }
}
