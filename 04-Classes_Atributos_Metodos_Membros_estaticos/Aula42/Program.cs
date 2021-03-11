using System;

namespace Aula42
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine(p);

            Console.Write("\nDigite o numero de produtos a serem adicionados: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));
            
            Console.WriteLine(p);

            Console.Write("\nDigite o numero de produtos a serem removidos: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine(p);
        }
    }
}
