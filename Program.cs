using System;
using System.Collections.Generic;

namespace SudokuSolver
{
  class Program
  {
    static void Main(string[] args)
    {
      var grid = new int[9, 9]
      {
            {0,0,0, 0,0,0, 0,0,0},
            {0,0,0, 0,0,0, 0,0,0},
            {0,0,0, 0,0,0, 0,0,0},
            //             
            {0,0,0, 0,0,0, 0,0,0},
            {0,0,0, 0,0,0, 0,0,0},
            {0,0,0, 0,0,0, 0,0,0},
            //             
            {0,0,0, 0,0,0, 0,0,0},
            {0,0,0, 0,0,0, 0,0,0},
            {0,0,0, 0,0,0, 0,0,0}
      };

      var possibilities = GetPossibilities(grid);
    }

    private static int[] GetRowValues(int[,] filledGrid, int x, int y, int offset = 0)
    {

    }

    private static int[] GetColumnValues(int[,] filledGrid, int x, int y, int offset = 0)
    {

    }

    private static int[] GetBlockValues(int[,] filledGrid, int x, int y)
    {

    }

    private static List<int>[,] GetPossibilities(int[,] filledValues)
    {
      // for each cell that is 0 (i.e. not filled in)
      //// get other column values
      //// + get other row values
      //// + get other block values
      //// intersect [1..9] with above
    }

    private static int[,] ResolvePossibilities(List<int>[,] possibleValues)
    {

    }
  }

  public static class Extensions
  {
    public static IEnumerable<T> GetRow<T>(this T[,] input2DArray, int row) where T : IComparable
    {
      var width = input2DArray.GetLength(0);
      var height = input2DArray.GetLength(1);

      if (row >= height)
        throw new IndexOutOfRangeException("Row Index Out of Range");
      // Ensures the row requested is within the range of the 2-d array

      for (var i = 0; i < width; i++)
      {
        yield return input2DArray[i, row];
      }
    }

    public static IEnumerable<T> GetColumn<T>(this T[,] input2DArray, int col) where T : IComparable
    {
      var width = input2DArray.GetLength(0);
      var height = input2DArray.GetLength(1);

      if (col >= width)
        throw new IndexOutOfRangeException("Column Index Out of Range");
      // Ensures the row requested is within the range of the 2-d array

      for (var i = 0; i < height; i++)
      {
        yield return input2DArray[col, i];
      } 
    }
  }
}