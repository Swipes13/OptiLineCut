using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace OptiLineCut.src {
  public class Detail2D : Detail1D {
    [CategoryAttribute("Настраиваемые параметры"), DescriptionAttribute("Ширина")]
    public double Width { get { return size[1]; } set { size[1] = value; calculateVolume(); parent.Refresh(); } }

    private Detail2D() { Dimension = 2; }
    public Detail2D(PropertyGrid grdParent, double[] size_) {
      parent = grdParent;
      Dimension = 2;
      if (size_.Count() != Dimension)
        throw new InvalidOperationException("Деталь имеет размерность меньшую, чем Вы ожидали :)");

      size = new double[Dimension];
      for (int i = 0; i < size_.Count(); i++)
        size[i] = size_[i];

      calculateVolume();
    }

  }
}
