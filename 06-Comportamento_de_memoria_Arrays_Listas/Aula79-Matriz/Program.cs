using System;

namespace Aula79_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {   
            //instanciando uma matriz
            double[,] mat = new double[2, 3];
            
            //pegando o tamanho total da matriz, quantidade de elementos dentro dela
            Console.WriteLine(mat.Length);
            
            //Quanto vale a primeira dimensão da matriz, quantidade de linhas
            Console.WriteLine(mat.Rank);
            
            //Mostra o valor da primeira dimensão, linhas
            Console.WriteLine(mat.GetLength(0));
            
            //Mostra o valor da segunda dimensão, colunas
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
