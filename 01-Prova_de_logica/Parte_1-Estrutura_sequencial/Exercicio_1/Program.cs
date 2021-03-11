using System;
using System.Globalization;
namespace Exercicio_1
{
    /*
        Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
        código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
    */
    class Program
    {
        static void Main(string[] args)
        {
            int codigo=0, quantidade=0; 
            float valor=0, resultado=0;

            for(int i =0; i<2;i++){
                Console.WriteLine("Informe o codigo, quanitade e valor, da peça: ");
                codigo = Convert.ToInt32(Console.ReadLine());
                quantidade = Convert.ToInt32(Console.ReadLine());
                valor = Convert.ToSingle(Console.ReadLine());

                resultado += quantidade*valor;
            }

            Console.WriteLine("Valor a pagar: R$ "+resultado.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
