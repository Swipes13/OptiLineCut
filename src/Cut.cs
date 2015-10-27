using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiLineCut.src {
  public class Cut {
    Detail billet;
    Detail mainDetail;

    private double sectThick;
    public double Left { get { return left; } private set { } }
    private double left;
    public List<OrderPair> Pairs = new List<OrderPair>();

    public Cut(Detail billet_, Detail mainDetail_, double sectThick_, double left_) {
      billet = billet_;
      mainDetail = mainDetail_;
      sectThick = sectThick_;
      left = left_;
    }
    public int CountOf(Detail detail) {
      foreach (OrderPair pair in Pairs)
        if (pair.Detail.Volume == detail.Volume)
          return pair.Num;
      return 0;
    }
    public void Remove(Detail detail, double sect) {
      for (int i = 0; i < Pairs.Count; i++) {
        if (Pairs[i].Detail.Volume == detail.Volume) {
          Pairs[i].Num--;
          left += sect + Pairs[i].Detail.Volume;
          sectThick -= sect;
          if (Pairs[i].Num == 0)
            Pairs.RemoveAt(i);

          break;
        }
      }
    }
    public Detail RemoveButNotLast(Detail lastMinDetail, double sect) {
      // не главную и не последнюю!
      for (int i = Pairs.Count - 1; i >= 0; i--) {
        if (Pairs[i].Detail.Volume != mainDetail.Volume) {
          if (lastMinDetail.Volume == Pairs[i].Detail.Volume)
            continue;

          Pairs[i].Num--;
          left += sect + Pairs[i].Detail.Volume;
          sectThick -= sect;

          if (i + 1 < Pairs.Count)
            for (int j = i + 1; j < Pairs.Count; j++) {
              left += (sect + Pairs[i + 1].Detail.Volume) * Pairs[i + 1].Num;
              sectThick -= sect * Pairs[i + 1].Num;
              Pairs.RemoveAt(i + 1);
            }

          if (Pairs[i].Num == 0) {
            Detail retDet = Pairs[i].Detail;
            Pairs.RemoveAt(i);
            return retDet;
          }
          return Pairs[i].Detail;
        }
      }

      return null;
    }
    public void Fill(Detail det, double sect) {
      int count = (int)(left / (det.Volume + sect));
      int countSect = count;
      double fillSize = count * (det.Volume + sect);
      if (left - fillSize >= det.Volume) {
        count++;
        fillSize += det.Volume;
      }
      sectThick += countSect * sect;
      left -= fillSize;

      if (count != 0)
        Pairs.Add(new OrderPair(det, count));
    }
    public Cut Clone() {
      Cut retCut = new Cut(billet, mainDetail, sectThick, left);
      foreach (OrderPair pair in Pairs)
        retCut.Pairs.Add(new OrderPair(pair.Detail, pair.Num));
      return retCut;
    }
  }
}
