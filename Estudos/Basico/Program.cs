﻿using System;

namespace Basico
{
  class Program
  {
    enum Notas
    {
      Minimo = 2,
      Media = 6,
      Maxima = 10
    }

    struct Pessoa
    {
      public string nome;
      public int idade;
      public double altura;
    }

    static void Main(string[] args)
    {
      // Este comando imprime a mensagem
      Console.WriteLine("Ola Mundo!");
      /* Este comando aguarda pressionar uma tecla */
      Console.ReadKey();

      //Criando regiões de códigos e está pode ser nomeada
      #region Variáveis
      //Existem variaveis por valor e por referência

      #region Numericas Integrais
      //// Integral assinado
      //sbyte num1 = 10; // 8 bits, de -128 a 127
      //short num2 = 20; // 16 bits, –32.768 a 32.767
      //int num3 = 30; // 32 bits, –2.147.483.648 a 2.147.483.647
      //long num4 = 40L; // 64 bits, –9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

      //// Integral sem sinal
      //byte num5 = 10; // 8 bits, intervalo de 0 a 255
      //ushort num6 = 20; // 16 bits, de 0 a 65.535
      //uint num7 = 30;  // 32 bits, de 0 a 4.294.967.295
      //ulong num8 = 40L; // 64 bits, de 0 a 18.446.744.073.709.551.615

      //sbyte numero;
      //numero = 100;

      //numero = 120;
      //numero = num1;
      #endregion

      #region Números Reais
      //float real1 = 100.75f; // 32 bits, de 1,5 × 10-45 a 3,4 × 1038, precisão de 7 dígitos => Sufixo f, Ex.: 10.5f
      //double real2 = 12500.45; // 64 bits, de 5,0 × 10-324 a 1,7 × 10308, precisão de 15 dígitos => Sufixo d (opcional), Ex.: 10.5d
      //decimal real3 = 752538.457m; // 128 bits, intervalo de pelos menos –7,9 × 10-28 a 7,9 × 1028, com precisão de pelo menos 28 dígitos => Sufixo m, Ex.: 10.5m

      //double valor;
      //valor = real1;
      #endregion

      #region Caractere
      //char letra = '\u0041';
      //char escape = '\n';
      //char nullo = '\0';
      //char literal = 'C';
      #endregion

      #region Boolean
      //bool verificar = false;
      //verificar = true;
      #endregion

      #region String (Cadeia de Caracteres)
      //string texto = "Gabriel Artigas\n 1985 @@??$$";
      //string texto2 = @"Gabriel Artigas\n 1985 @@??$$"; //imprime o \n, ignora os caracteres especiais
      //string mensagem = null;
      //mensagem = texto;
      #endregion

      #region Tipo Implícito Var
      //var valor = 100;
      //valor = 20;
      //valor = "Gabriel"; //Erro
      #endregion

      #region Tipo Object (Base para todos os tipos)
      //object obj = false;
      //obj = 200;
      //obj = "Gabriel";
      #endregion

      #region Constantes
      //const double pi = 3.1415;
      //const string nome = "Gabriel";
      #endregion

      #region Enum
      //Notas notasAlunos = Notas.Media;
      #endregion

      #region Estruturas (Value Type)
      Pessoa p1 = new Pessoa();
      p1.nome = "João";
      p1.idade = 25;
      p1.altura = 1.85;

      Pessoa p2 = new Pessoa()
      {
        nome = "Maria",
        idade = 21,
        altura = 1.75,
      };

      Console.WriteLine(p1.nome);
      Console.WriteLine(p2.nome);
      #endregion

      #endregion

      #region Entrada e saída de dados
      Console.Write("Saída sem quebra de linha.");
      Console.WriteLine("Saída");

      // letra = Console.Read(); // Lê o pimeiro caracter digitado e retorna se valor inteiro ASCII dec.
      //Console.WriteLine(letra);

      string entrada = Console.ReadLine();
      Console.WriteLine(entrada);

      //Console.ReadKey(true);
      Console.ReadKey();
      #endregion

    }
  }
}
