using System;
using System.Globalization;
namespace Aula18
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo o preço é {preco1:F2}");
            Console.WriteLine("{0}, cujo o preco é {1:F2}", produto2, preco2);

            Console.WriteLine("\nRegistro: " + idade +" anos de idade, codigo " + codigo + " e gênero: " + genero);

            Console.WriteLine("\nMedida com oito casas deciamis: {0:F8}", medida);
            Console.WriteLine("Arredondando (três casas deciamais): {0:F3}", medida);
            Console.WriteLine("Separador decimal invariant culture: "+ medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
