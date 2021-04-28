using System;

namespace cs_calculadora
{
  class Program
  {
    static void Main(string[] args)
    {
    //Label
    Inicio:
      Console.Clear();

      Console.Write("Digite o primeiro número: ");
      int num1 = int.Parse(Console.ReadLine());

      Console.Write("Digite o operador: ");
      char operador = char.Parse(Console.ReadLine());

      Console.Write("Digite o primeiro número: ");
      int num2 = int.Parse(Console.ReadLine());

      int resultado = 0;

      switch (operador)
      {
        case '+':
          resultado = num1 + num2;
          break;
        case '-':
          resultado = num1 - num2;
          break;
        case 'x':
        case '*':
          resultado = num1 * num2;
          break;
        case ':':
        case '/':
          if (num2 == 0)
            Console.WriteLine("Não é possivel fazer a divisão");
          else
            resultado = num1 / num2;
          break;
        default:
          Console.WriteLine("Operador não é valido.");
          goto Inicio;
      }

      Console.WriteLine("Resultado: " + resultado);

      Console.Write("Continuar calculando? (s / n)");
      string op = Console.ReadLine();

      if (op == "s" || op == "S")
        goto Inicio;

    }
  }
}
