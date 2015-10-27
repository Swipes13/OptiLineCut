using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptiLineCut.src {
  public partial class OrderForm : Form {
    public int Count = 10;
    public Detail Detail;

    public OrderForm(int dimension) {
      InitializeComponent();
      tbxCount.Text = Count.ToString();
      switch(dimension){
        case 1: Detail = new Detail1D(pgrdTest, new double[] { 1.0 }); break;
        case 2: Detail = new Detail2D(pgrdTest, new double[] { 1.0, 1.0 }); break;
        default: throw new NotImplementedException();
      }
      pgrdTest.SelectedObject = Detail;
    }
    
    public OrderForm(Detail det, int num) {
      InitializeComponent();
      Count = num;
      tbxCount.Text = Count.ToString();

      switch(det.Dimension){
        case 1: Detail = new Detail1D(pgrdTest, new double[] { ((Detail1D)det).Length }); break;
        case 2: Detail = new Detail2D(pgrdTest, new double[] { ((Detail2D)det).Length, ((Detail2D)det).Width }); break;
        default: throw new NotImplementedException();
      }
      pgrdTest.SelectedObject = Detail;
    }

    private void tbxCount_TextChanged(object sender, EventArgs e) {
      try {
        Count = Convert.ToInt32(tbxCount.Text);
      }
      catch (Exception) { }
    }

  }
}
