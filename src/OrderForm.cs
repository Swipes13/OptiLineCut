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

    public OrderForm() {
      InitializeComponent();
      tbxCount.Text = Count.ToString();
    }

    private void tbxCount_TextChanged(object sender, EventArgs e) {
      try {
        Count = Convert.ToInt32(tbxCount.Text);
      }
      catch (Exception) { }
    }

  }
}
