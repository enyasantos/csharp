using System;

namespace cs_multiplicacao_matrizes
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] mat1 = {
        {5, 4, 6},
        {4, 5, 2}
      };

      int[,] mat2 = {
        {4, 2},
        {6, 4},
        {1, 6}
      };

      int[,] matMultiplicacao = new int[2, 2];

      matMultiplicacao[0, 0] = mat1[0, 0] * mat2[0, 0] + mat1[0, 1] * mat2[1, 0] + mat1[0, 2] * mat2[2, 0];
      matMultiplicacao[0, 1] = mat1[0, 0] * mat2[0, 1] + mat1[0, 1] * mat2[1, 1] + mat1[0, 2] * mat2[2, 1];

      matMultiplicacao[1, 0] = mat1[1, 0] * mat2[0, 0] + mat1[1, 1] * mat2[1, 0] + mat1[1, 2] * mat2[2, 0];
      matMultiplicacao[1, 1] = mat1[1, 0] * mat2[0, 1] + mat1[1, 1] * mat2[1, 1] + mat1[1, 2] * mat2[2, 1];

      for (int i = 0; i < 2; i++)
      {
        for (int j = 0; j < 2; j++)
        {
          Console.Write("[" + matMultiplicacao[i, j] + "]  ");
        }
        Console.WriteLine();
      }

    }
  }
}
