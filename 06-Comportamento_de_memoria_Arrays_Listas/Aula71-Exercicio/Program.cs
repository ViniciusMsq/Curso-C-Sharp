using System;

namespace Aula71
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd;
            Pensionato[] p = new Pensionato[10];
            Console.Write("Quantos quarto ira registrar: ");
            qtd = int.Parse(Console.ReadLine());

            for(int i = 0; i<qtd; i++){
                Console.WriteLine("\nAluguel #{0}:", (i+1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                p[quarto] = new Pensionato(nome, email);
            }
            for(int i = 0; i<10; i++){
                if(p[i]!= null){
                    Console.WriteLine("{0}: {1}", i, p[i]);
                }
            }
        }
    }
}
