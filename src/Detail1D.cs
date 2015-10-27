using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace OptiLineCut.src {
  public class Detail1D : Detail {
    [CategoryAttribute("Настраиваемые параметры"), DescriptionAttribute("Длина")]
    public double Length { get { return size[0]; } set { size[0] = value; calculateVolume(); parent.Refresh(); } }

    protected Detail1D() { Dimension = 1; }

    public Detail1D(PropertyGrid grdParent, double[] size_) {
      parent = grdParent;
      Dimension = 1;
      if (size_.Count() != Dimension)
        throw new InvalidOperationException("Деталь имеет размерность меньшую, чем Вы ожидали :)");

      size = new double[Dimension];
      for (int i = 0; i < size_.Count(); i++) 
        size[i] = size_[i];

      calculateVolume();
    }

    public override Cut Fill(Detail det, double sect) {
      int count = (int)(Volume / (det.Volume + sect));
      int countSect = count;
      double fillSize = count * (det.Volume + sect);
      if (Volume - fillSize >= det.Volume) {
        count++;
        fillSize += det.Volume;
      }

      Cut retCut = new Cut(this, det, countSect * sect, Volume - fillSize);
      retCut.Pairs.Add(new OrderPair(det, count));

      return retCut;
    }

    protected override void calculateVolume() {
      Volume = 1.0;
      for (int i = 0; i < size.Count(); i++) 
        Volume *= size[i];
    }
  }
}
