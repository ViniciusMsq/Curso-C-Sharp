using System;

namespace Aula75_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Bob", "Alex"};

            //Leitura: "para cada objeto 'obj' contido em vect, faça:"
            //caminhas por todos os itens do vetor e faz sua impressão
            foreach (string obj in vect) {
                Console.WriteLine(obj);
            }
        }
    }
}
