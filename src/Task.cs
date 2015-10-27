using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiLineCut.src {
  class Task {
    // Размерность задачи
    public int Dimension { get { return dimension; } protected set { dimension = value; } }
    private int dimension;

    // Величина среза
    public double CutThick { get { return cutThick; } set { cutThick = value; } }
    private double cutThick = 0.05;

    // Заготовка
    private Detail billet;

    // Заказ
    public Order order = new Order();
    private List<Cut> cuts = new List<Cut>();

    // Все разрезы
    public List<Cut> AllCuts = new List<Cut>();

    public OrderPair GetNextOrderPair(OrderPair pair) {
      for (int i = 0; i < order.Count; i++)
        if (pair == order[i] && i != order.Count - 1)
          return order[i + 1];
      return null;
    }

    public Task(int dim, Detail billet_) {
      Dimension = dim;
      if (billet_.Dimension != Dimension)
        throw new InvalidOperationException("Размерность заготовки не совпадает с размерностью самой задачи!");

      billet = billet_;
    }

    public Task(int dim, Detail billet_, OrderPair[] order_) {
      Dimension = dim;
      if (billet_.Dimension != Dimension)
        throw new InvalidOperationException("Размерность заготовки не совпадает с размерностью самой задачи!");

      billet = billet_;

      foreach (OrderPair p in order_) {
        if (p.Detail.Dimension == Dimension)
          order.Add(p);
        else
          throw new InvalidOperationException("Размерность одной из деталей заказа не совпадает с размерностью самой задачи!");
      }
    }

    public void AddOrder(OrderPair pair) {
      if (pair.Detail.Dimension == Dimension)
        order.Add(pair);
      else
        throw new InvalidOperationException("Размерность одной из деталей заказа не совпадает с размерностью самой задачи!");
    }

    public void Compute() {
      AllCuts = new List<Cut>();
      order.OrderByDesc();

      for (int iDet = 0; iDet < order.Count - 1; iDet++) {
        Cut detCut = billet.Fill(order[iDet].Detail, CutThick);
        int index = 1;

        while (detCut.CountOf(order[iDet].Detail) != 0) {

          for (int j = iDet + 1; j < order.Count; j++)
            detCut.Fill(order[j].Detail, CutThick);

          AllCuts.Add(detCut.Clone());

          Detail nextDet = detCut.RemoveButNotLast(order.LastDetail(), CutThick);  // не главная и не самая маленька деталь!
          if (nextDet != null)
            nextDet = order[order.GetNumber(nextDet) + 1].Detail;
          while (nextDet != null) {
            for (int j = order.GetNumber(nextDet); j < order.Count; j++)
              detCut.Fill(order[j].Detail, CutThick);

            AllCuts.Add(detCut.Clone());
            nextDet = detCut.RemoveButNotLast(order.LastDetail(), CutThick);
            if (nextDet != null)
              nextDet = order[order.GetNumber(nextDet) + 1].Detail;
          }
          detCut = billet.Fill(order[iDet].Detail, CutThick);
          for (int i = 0; i < index; i++)
            detCut.Remove(order[iDet].Detail, CutThick);
          index++;
        }
      }
      AllCuts.Add(billet.Fill(order.LastDetail(), CutThick));
    }
  }
}
