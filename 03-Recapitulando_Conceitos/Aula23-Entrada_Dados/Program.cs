using System;
using System.Globalization;
namespace Aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            char letra = char.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            string[] s = Console.ReadLine().Split(' ');

            string nome = s[0];
            char l  = char.Parse(s[1]);
            int idade = int.Parse(s[2]);
            float altura = float.Parse(s[3]);

            Console.WriteLine("Digitado: ");
            Console.WriteLine(x);
            Console.WriteLine(letra);
            Console.WriteLine(y.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(l);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));


        }
    }
}
