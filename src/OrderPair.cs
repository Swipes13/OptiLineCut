using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiLineCut.src {
  public class OrderPair {
    private OrderPair() {
      Detail = null;
      Num = 0;
    }
    public OrderPair(Detail det, int numDet) {
      Detail = det;
      Num = numDet;
    }
    public Detail Detail { get { return detail; } private set { detail = value; } }
    private Detail detail;
    public int Num { get { return num; } set { num = value; } }
    private int num;
  }
}
