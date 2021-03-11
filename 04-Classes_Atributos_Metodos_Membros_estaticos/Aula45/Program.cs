using System;
using System.Globalization;
namespace Aula45
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            r.Lagura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA: " + r.Area().ToString("F2"));
            Console.WriteLine("PERIMETRO: " + r.Perimetro().ToString("F2"));
            Console.WriteLine("DIAGONAL: " + r.Diagonal().ToString("F2"));
        }
    }
}
