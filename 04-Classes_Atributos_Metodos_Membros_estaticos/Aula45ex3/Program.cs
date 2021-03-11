using System;

namespace Aula45ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.nome = Console.ReadLine();

            Console.WriteLine("Digite as 3 notas: ");
            a.nota1 = double.Parse(Console.ReadLine());
            a.nota2 = double.Parse(Console.ReadLine());
            a.nota3 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("NOTA FINAL = " + a.NotaFinal().ToString("F2"));
            Console.WriteLine(a.Aprovado(a.NotaFinal()));
        }
    }
}
