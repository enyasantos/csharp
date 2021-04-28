using System;

namespace cs_conversor_temperatura
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("###CONVERSOR DE TEMPERATURA###");
      Console.Write("Temperatura em Celsius: ");
      double tempCelsius = int.Parse(Console.ReadLine());

      double tempFahrenheit = (tempCelsius * 1.8) + 32;

      double tempKelvin = tempCelsius + 273.15;

      Console.WriteLine(tempCelsius + "C equivale a:");
      Console.WriteLine("Fahrenheit: " + tempFahrenheit + "\nKelvin: " + tempKelvin);
    }
  }
}
