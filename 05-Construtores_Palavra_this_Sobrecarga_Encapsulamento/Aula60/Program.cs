using System;

namespace Aula60
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco bank;
            string titular;
            int conta;
            double valor = 0.00;
            char cond;

            Console.Write("Entre com o numero da conta: ");
            conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            cond = char.Parse(Console.ReadLine());

            if(cond == 's' || cond == 'S' ) {
                Console.Write("Entre o valor de deposito inicial: ");
                valor = double.Parse(Console.ReadLine());
                bank = new Banco(conta, titular, valor);
            }else{
                bank = new Banco(conta, titular);
            }

            Console.WriteLine("Dados da conta:\n{0}", bank);

            Console.Write("Entre com o valor do deposito: ");
            bank.Depositar(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados:\n{0}", bank);

            Console.Write("Entre com o valor do Saque: ");
            bank.Saque(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados:\n{0}", bank);
        }
    }
}
