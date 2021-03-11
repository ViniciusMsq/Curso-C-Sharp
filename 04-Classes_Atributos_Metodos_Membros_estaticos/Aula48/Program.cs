using System;

namespace Aula48
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Cotação do dolar hoje: ");
            double dolarHoje = double.Parse(Console.ReadLine());
            Console.Write("Quantos dolares voce vai comprar: ");
            double dolarQtd = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor pago em reais = " + Conversor.ValorReais(dolarHoje, dolarQtd).ToString("F2"));           
        }
    }
}
