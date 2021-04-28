using System;

namespace cs_fibonacci
{
  class Program
  {
    static void Main(string[] args)
    {
      int a = 0, b = 1, c = 1;

      Console.Write("Número de valores da sequência: ");
      int n = int.Parse(Console.ReadLine());

      if (n == 1)
        Console.WriteLine(a);
      else if (n == 2)
        Console.WriteLine(a + " " + b);
      else if (n >= 3)
      {
        Console.Write(a + " " + b + " " + c + " ");

        for (int i = 0; i < n - 3; i++)
        {
          a = b + c;
          Console.Write(a + " ");
          b = c;
          c = a;
        }
      }

      Console.WriteLine();

    }
  }
}
