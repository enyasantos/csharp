using System;

namespace cs_calculadora_imc
{
  class Program
  {
    struct Pessoa
    {
      public string nome;
      public double peso;
      public double altura;
      public double imc;
    }
    static void Main(string[] args)
    {
      Pessoa p1 = new Pessoa();
      Console.WriteLine("Calculadora de IMC");
      Console.Write("Nome: ");
      p1.nome = Console.ReadLine();
      Console.Write("Peso(Kg): ");
      p1.peso = Convert.ToDouble(Console.ReadLine());
      Console.Write("Altura(m): ");
      p1.altura = Convert.ToDouble(Console.ReadLine());
      p1.imc = p1.peso / Math.Pow(p1.altura, 2);

      if (p1.imc < 18.5)
        Console.WriteLine("Classificação: Magreza\t|\tObesidade(grau): 0");
      else if (p1.imc < 24.9)
        Console.WriteLine("Classificação: Normal\t|\tObesidade(grau): 0");
      else if (p1.imc < 29.9)
        Console.WriteLine("Classificação: Sobrepeso\t|\tObesidade(grau): I");
      else if (p1.imc < 39.9)
        Console.WriteLine("Classificação: Obesidade\t|\tObesidade(grau): II");
      else
        Console.WriteLine("Classificação: Obesidade Grave\t|\tObesidade(grau): III");
    }
  }
}
