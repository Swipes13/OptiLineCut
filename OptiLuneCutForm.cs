using System;
using System.IO;
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
      OrderForm sForm = new OrderForm(cmbDimension.SelectedIndex + 1);
      DialogResult dr = sForm.ShowDialog();

      if (dr != System.Windows.Forms.DialogResult.OK)
        return;

      lbxOrderDetails.Items.Add("Detail_" + lbxOrderDetails.Items.Count.ToString() + "    num:" + sForm.Count.ToString());
      order.Add(new OrderPair(sForm.Detail, sForm.Count));
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

    private void mnuFilESaveTask_Click(object sender, EventArgs e) {
      SaveFileDialog sfd = new SaveFileDialog();

      sfd.Filter = "task files (*.tsk)|*.tsk";
      sfd.FilterIndex = 1;
      sfd.RestoreDirectory = true;

      if (sfd.ShowDialog() == DialogResult.OK) {
        if (sfd.FileName != null) {
          StreamWriter sw = new StreamWriter(sfd.FileName);

          sw.Write("=== Задача линейного раскроя ===");
          sw.Write(Environment.NewLine);
          sw.Write("Размерность задачи: ");
          sw.Write(((Detail)pgrdTest.SelectedObject).Dimension);
          sw.Write(Environment.NewLine);
          sw.Write("Величина среза: ");
          sw.Write(cutThick);
          sw.Write(Environment.NewLine);
          sw.Write("Заготовка:");
          sw.Write(Environment.NewLine);
          switch (cmbDimension.SelectedIndex) {
            case 0:
              sw.Write(((Detail1D)pgrdTest.SelectedObject).Length);
          sw.Write(Environment.NewLine);
              break;
            case 1:
              sw.Write(((Detail2D)pgrdTest.SelectedObject).Length);
              sw.Write(" ");
              sw.Write(((Detail2D)pgrdTest.SelectedObject).Width);
              sw.Write(Environment.NewLine);
              break;
            default:
              throw new NotImplementedException("Не реализованный код!");
          }
          sw.Write("Заказ: ");
          sw.Write(order.Count);
          sw.Write(Environment.NewLine);
          foreach (OrderPair pair in order) {
            switch (cmbDimension.SelectedIndex) {
              case 0:
                sw.Write(pair.Num);
                sw.Write(" ");
                sw.Write(((Detail1D)pair.Detail).Length);
                sw.Write(Environment.NewLine);
                break;
              case 1:
                sw.Write(pair.Num);
                sw.Write(" ");
                sw.Write(((Detail2D)pair.Detail).Length);
                sw.Write(" ");
                sw.Write(((Detail2D)pair.Detail).Width);
                sw.Write(Environment.NewLine);
                break;
              default:
                throw new NotImplementedException("Не реализованный код!");
            }
          }


          sw.Close();
        }
      }
    }

    private void mnuFilELoadTask_Click(object sender, EventArgs e) {
      OpenFileDialog ofd = new OpenFileDialog();

      ofd.InitialDirectory = "c:\\";
      ofd.Filter = "task files (*.tsk)|*.tsk";
      ofd.FilterIndex = 1; ofd.RestoreDirectory = true;

      if (ofd.ShowDialog() == DialogResult.OK) {
        try {
          if (ofd.FileName != null) {
            lbxOrderDetails.Items.Clear();
            order.Clear();
            pgrdOrderDetail.SelectedObject = null;

            StreamReader sr = new StreamReader(ofd.FileName);
            sr.ReadLine();
            String st = sr.ReadLine();
            String[] sts = st.Split(new char[]{' '});
            int dimTask = Convert.ToInt32(sts[2]);
            cmbDimension.SelectedIndex = dimTask - 1;
            st = sr.ReadLine();
            sts = st.Split(new char[] { ' ' });
            cutThick = Convert.ToDouble(sts[2]);
            tbxCutTHick.Text = cutThick.ToString().Replace(',','.');
            sr.ReadLine();
            st = sr.ReadLine();
            sts = st.Split(new char[] { ' ' });

            Detail det;
            switch (dimTask) {
              case 1:
                det = new Detail1D(pgrdTest, new double[] { Convert.ToDouble(sts[0]) });
                break;
              case 2:
                det = new Detail2D(pgrdTest, new double[] { Convert.ToDouble(sts[0]), Convert.ToDouble(sts[1]) });
                break;
              default:
                throw new NotImplementedException("Размерность ошибка!");
            }
            pgrdTest.SelectedObject = det;

            st = sr.ReadLine();
            sts = st.Split(new char[] { ' ' });

            int countOrder = Convert.ToInt32(sts[1]);
            for (int i = 0; i < countOrder; i++) {
              st = sr.ReadLine();
              sts = st.Split(new char[] { ' ' });

              Detail detOrder;
              switch (dimTask) {
                case 1:
                  detOrder = new Detail1D(pgrdOrderDetail, new double[] { Convert.ToDouble(sts[1]) });
                  break;
                case 2:
                  detOrder = new Detail2D(pgrdOrderDetail, new double[] { Convert.ToDouble(sts[1]), Convert.ToDouble(sts[2]) });
                  break;
                default:
                  throw new NotImplementedException("Размерность ошибка!");
              }
              order.Add(new OrderPair(detOrder, Convert.ToInt32(sts[0])));
              lbxOrderDetails.Items.Add("Detail_" + lbxOrderDetails.Items.Count.ToString() + "   num:" + sts[0]);
            }

            sr.Close();
          }
        }
        catch (Exception ex) {
          MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
        }
      }
    }

    private void lbxOrderDetails_DoubleClick(object sender, EventArgs e) {
      int ind = lbxOrderDetails.SelectedIndex;

      if (ind == -1) return;

      OrderForm sForm = new OrderForm(order[ind].Detail, order[ind].Num);
      DialogResult dr = sForm.ShowDialog();

      if (dr != System.Windows.Forms.DialogResult.OK)
        return;

      lbxOrderDetails.Items[ind] = ("Detail_" + ind.ToString() + "   num:" + sForm.Count.ToString());
      order[ind] = new OrderPair(sForm.Detail, sForm.Count);

      pgrdOrderDetail.SelectedObject = order[ind].Detail;
    }
  }
}
