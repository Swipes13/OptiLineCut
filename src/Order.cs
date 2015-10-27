using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace OptiLineCut.src {
  class Order {
    public OrderPair this[int index] {
      get { return order[index]; }
      set { order[index] = value; }
    }
    public int GetNumber(Detail detail) {
      for (int i = 0; i < order.Count; i++) {
        if (order[i].Detail.Volume == detail.Volume)
          return i;
      }
      throw new InvalidProgramException("В разрезе нет детали, хотя должна быть)");
    }
    public void Add(OrderPair pair) {
      order.Add(pair);
    }
    public OrderPair First() {
      return order.First();
    }
    public Detail LastDetail() {
      return order.Last().Detail;
    }
    public void OrderByDesc() {
      order = order.OrderByDescending(x => x.Detail.Volume).ToList();
    }

    public int Count { get { return order.Count; } private set { } }

    private List<OrderPair> order = new List<OrderPair>();
  }
}
