using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    abstract public class Forma
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Raio { get; set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando-se para desenhar");
        }

        public virtual void Area()
        {
            int area = Largura * Altura;
            Console.WriteLine("Area: " + area);
        }
    }

    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um Circulo");            
        }

        public override void Area()
        {
            double area = 3.14 * (Raio * Raio);
            Console.WriteLine("Area Circulo " + area);
        }
    }

    public class Retangulo : Forma
    {
        public override void Desenhar()
        {
            // Code to draw a Retangulo...
            Console.WriteLine("Desenhando um Retangulo");
            base.Desenhar();
        }

        public override void Area()
        {
            base.Area();            
        }
    }

    public class Triangulo : Forma
    {
        public override void Desenhar()
        {
            // Code to draw a Triangulo...
            Console.WriteLine("Desenhando um Triangulo");
            base.Desenhar();
        }

        public override void Area()
        {
            int area = (Largura * Altura) / 2;
            Console.WriteLine("Area Triangulo " + area);
        }
    }
}
