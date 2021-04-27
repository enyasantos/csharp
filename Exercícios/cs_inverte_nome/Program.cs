using System;

namespace cs_inverte_nome
{
  class Program
  {
    static void Main(string[] args)
    {
      string nome1, nome2, nome3, nome4;

      Console.Write("Digite o nome #1: ");
      nome1 = Console.ReadLine();

      Console.Write("Digite o nome #2: ");
      nome2 = Console.ReadLine();

      Console.Write("Digite o nome #3: ");
      nome3 = Console.ReadLine();

      Console.Write("Digite o nome #4: ");
      nome4 = Console.ReadLine();

      string aux;
      aux = nome1;
      nome1 = nome4;
      nome4 = aux;
      aux = nome2;
      nome2 = nome3;
      nome3 = aux;

      Console.WriteLine("Nomes invertidos na sequência invertida:");
      Console.WriteLine(nome1);
      Console.WriteLine(nome2);
      Console.WriteLine(nome3);
      Console.WriteLine(nome4);
    }
  }
}
