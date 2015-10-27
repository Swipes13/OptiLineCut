using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiLineCut.src.SMethod {
  public class Task {
    public List<Limitation> limitations = new List<Limitation>();
    public EquaLine equaLine;
    public SimplexMethodSolver.Type type;

    public Task(EquaLine line) {
      equaLine = line;
      type = SimplexMethodSolver.Type.Min;
    }
}
  public class EquaLine {
    public List<double> koeffs = new List<double>();
    public double rightValue;

    public EquaLine(double[] koeffs_, double right) {
      foreach (double val in koeffs_)
        koeffs.Add(val);
      rightValue = right;
    }

    public void ChangeSigns() {
      for (int i = 0; i < koeffs.Count; i++)
        koeffs[i] = -koeffs[i];
    }
    public void ChangeAllSigns() {
      ChangeSigns();
      rightValue = -rightValue;
    }
  }
  public class Limitation {
    public enum Type { Equal, Less, More, Undefined }
    public Type type = Type.Undefined;

    public EquaLine equaLine;

    public Limitation(double[] koeffs_, double right, Type type_) {
      equaLine = new EquaLine(koeffs_, right);
      type = type_;
    }
    public void ChangeSigns() {
      equaLine.ChangeSigns();
    }
    public void ChangeAllSigns() {
      equaLine.ChangeAllSigns();
    }
  }
  public class SimplexMethodSolver {
    Task task;
    public String errMsg = "OK";
    public enum Type { Max, Min, Undefined }

    int countX = 0;

    public double[,] table;

    public List<int> xsStr = new List<int>();
    public List<int> xsCol = new List<int>();

    List<bool> nulStr = new List<bool>();

    public SimplexMethodSolver(Task task_) {
      task = task_;
      countX = task.equaLine.koeffs.Count();
      for (int i = 0; i < countX; i++)
        xsStr.Add(i + 1);

      if (task.type == Type.Undefined) { errMsg = "Не определён тип поиска целевой функции!"; return; }
      if (task.type == Type.Max) {
        task.equaLine.ChangeAllSigns();
        task.type = Type.Min;
      }

      int xsId = countX;
      foreach (Limitation limit in task.limitations) {
        switch (limit.type) {
          case Limitation.Type.Undefined: errMsg = "limit undefined!"; return;
          case Limitation.Type.More: limit.ChangeAllSigns(); limit.type = Limitation.Type.Less; break;
        }

        if (limit.type == Limitation.Type.Equal) { xsCol.Add(0); nulStr.Add(true); }
        else { xsId++; xsCol.Add(xsId); nulStr.Add(false); }
      }
      xsCol.Add(-1); nulStr.Add(false);

      table = new double[task.limitations.Count + 1, countX + 1];
      for (int i = 0; i < task.limitations.Count; i++) {
        for (int j = 0; j < countX; j++) {
          table[i, j] = task.limitations[i].equaLine.koeffs[j];
        }
        table[i, countX] = task.limitations[i].equaLine.rightValue;
      }
      for (int j = 0; j < countX; j++)
        table[task.limitations.Count, j] = -task.equaLine.koeffs[j];
      table[task.limitations.Count, countX] = task.equaLine.rightValue;
    }
    public bool calculateOptimalPlan() {
      if (!generateSupportPlan())
        return false;
      if (!generateOptimalPlan())
        return false;

      return true;
    }
    private bool generateSupportPlan() {
      for (int i = 0; i < nulStr.Count(); i++) {
        if (nulStr[i]) {
          nulStr[i] = false;
          int accCol = chooseAcceptColumn(i);
          if (accCol < 0) {
            errMsg = "generateSupportPlan failed! acceptCol";
            return false;
          }
          modifyJordanExcept(i, accCol);
          table = cutTable(table, accCol);
        }
      }
      while (true) {
        int otricStr = getOtricStr();
        if (otricStr < 0) return true;

        int accColmn = chooseAcceptColumn(otricStr);
        if (accColmn < 0) { errMsg = "Противоречива система!"; return false; }

        int accStr = chooseAcceptStr(accColmn);
        if (accStr < 0) { errMsg = "Выбор разрешающего элемента при построении опорного плана не получился!"; return false; }

        modifyJordanExcept(accStr, accColmn);
      }
    }
    private int getOtricStr() {
      for (int i = 0; i < table.GetLength(0) - 1; i++) {
        if (table[i, table.GetLength(1) - 1] < 0) {
          return i;
        }
      }
      return -1;
    }
    private int chooseAcceptColumn(int strIndex) {
      for (int i = 0; i < table.GetLength(1) - 1; i++) {
        if (table[strIndex, i] > 0)
          return i;
      }
      return -1;
    }
    private int chooseAcceptStr(int colIndex) {
      List<double> values = new List<double>();
      List<int> valuesIds = new List<int>();

      for (int str = 0; str < table.GetLength(0) - 1; str++) {
        double value = table[str, table.GetLength(1) - 1] / table[str, colIndex];
        if (value > 0.0) { values.Add(value); valuesIds.Add(str); }
      }
      if (valuesIds.Count <= 0) return -1;

      int minId = 0;
      for (int i = 1; i < values.Count; i++) {
        if (values[minId] > values[i])
          minId = i;
      }
      return valuesIds[minId];
    }
    private void modifyJordanExcept(int accStr, int accCol) {
      for (int str = 0; str < table.GetLength(0); str++) {
        if (str == accStr) continue;
        for (int col = 0; col < table.GetLength(1); col++) {
          if (col == accCol) continue;
          table[str, col] = table[str, col] - (table[accStr, col] * table[str, accCol]) / table[accStr, accCol];
        }
      }
      for (int str = 0; str < table.GetLength(0); str++) {
        if (str == accStr) continue;
        table[str, accCol] = -table[str, accCol] / table[accStr, accCol];
      }
      for (int col = 0; col < table.GetLength(1); col++) {
        if (col == accCol) continue;
        table[accStr, col] = table[accStr, col] / table[accStr, accCol];
      }
      table[accStr, accCol] = 1 / table[accStr, accCol];

      int xsstr = xsStr[accCol];
      xsStr[accCol] = xsCol[accStr];
      xsCol[accStr] = xsstr;
    }
    private double[,] cutTable(double[,] table, int colIndex) {
      double[,] newTable = new double[table.GetLength(0), table.GetLength(1) - 1];

      for (int i = 0; i < table.GetLength(0); i++) {
        for (int j = 0, newJ = 0; j < table.GetLength(1); j++, newJ++) {
          if (j == colIndex) { newJ--; continue; }
          newTable[i, newJ] = table[i, j];
        }
      }
      xsStr.RemoveAt(colIndex);
      return newTable;
    }
    private bool generateOptimalPlan() {
      while (true) {
        int accCol = chooseAcceptColumn(table.GetLength(0) - 1);
        if (accCol < 0) { table[table.GetLength(0) - 1, table.GetLength(1) - 1] = -table[table.GetLength(0) - 1, table.GetLength(1) - 1]; return true; }

        int accStr = chooseAcceptStr(accCol);
        if (accStr < 0) { errMsg = "Выбор разрешающего элемента при построении оптимального плана не получился!\nФункция неограничена снизу"; return false; }

        modifyJordanExcept(accStr, accCol);
      }
    }
  }
}
