using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiLineCut.src {
  public class Detail1D : Detail {
    private Detail1D() { Dimension = 1; }
    public Detail1D(double[] size_) {
      Dimension = 1;
      if (size_.Count() != Dimension)
        throw new InvalidOperationException("Деталь имеет размерность меньшую, чем Вы ожидали :)");

      size = new double[Dimension];

      Volume = 1.0;
      for (int i = 0; i < size_.Count(); i++) {
        size[i] = size_[i];
        Volume *= size_[i];
      }
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

  }
}
