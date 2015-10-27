using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace OptiLineCut.src {
  public abstract class Detail {
    // Размерность детали
    [CategoryAttribute("Основные характеристики"), DescriptionAttribute("Размерность детали")]
    public int Dimension { get { return dimension; } protected set { dimension = value; } }
    private int dimension = 0;

    [CategoryAttribute("Основные характеристики"), DescriptionAttribute("Объём детали")]
    public double Volume { get { return volume; }  protected set { volume = value; } }
    private double volume = 0;

    public double this[int index] {
      get {
        if (index >= dimension)
          throw new InvalidOperationException("Деталь имеет размерность меньшую, чем Вы ожидали :)");
        return size[index];
      }
      set {
        if (index >= dimension)
          throw new InvalidOperationException("Деталь имеет размерность меньшую, чем Вы ожидали :)");
        size[index] = value;
      }
    }

    [CategoryAttribute("Основные характеристики"), DescriptionAttribute("Размеры")]
    protected double[] size;

    protected PropertyGrid parent;

    public Detail() { }

    public abstract Cut Fill(Detail det, double sect);
    protected abstract void calculateVolume();
  }
}
