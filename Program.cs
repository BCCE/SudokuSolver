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
      return new List<int>[9, 9];
    }

    private static int[,] ResolvePossibilities(List<int>[,] possibleValues)
    {

    }
  }
}