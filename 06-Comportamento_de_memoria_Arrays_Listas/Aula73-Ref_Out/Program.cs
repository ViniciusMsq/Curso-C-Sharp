using System;

namespace Aula73_Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            
            // ref vai referenciar a variavel passada, vai ser alterada depois de sera aplicado o metodo
            // precisa ser iniciada a varivavel
            Calculator.TripleREF(ref a);
            Console.WriteLine(a);

            a = 10;
            int triple;
            // out vai alterar o valor da varivel triple mantendo a origem
            // não precisa ter a variavel iniciada
            Calculator.TripleOUT(a, out triple);
            Console.WriteLine(triple);

            //code smells
        }
    }
}
