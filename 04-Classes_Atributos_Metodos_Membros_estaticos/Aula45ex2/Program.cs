using System;

namespace Aula45ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.Salario = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: " + f);

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            f.AumentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: " + f);
        }
    }
}
