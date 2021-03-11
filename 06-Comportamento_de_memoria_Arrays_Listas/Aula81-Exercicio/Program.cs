using System;

namespace Aula81_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas, colunas;
            
            Console.Write("Informe a matriz, sendo 'linhas colunas': ");
            string[] values = Console.ReadLine().Split(' ');

            linhas = int.Parse(values[0]);
            colunas = int.Parse(values[1]);

            int[,] mat = new int[linhas, colunas];

            Console.WriteLine("Informe os valores da matriz linha a lnhas, dando espaço entre os números:");

            for(int i = 0; i<linhas;i++){

                values = Console.ReadLine().Split(' ');
                
                for(int j = 0; j<colunas; j++){
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            Console.Write("\n informe o número pertencente a matriz: ");
            int x = int.Parse(Console.ReadLine());

            for(int i = 0; i<linhas;i++){

                for(int j = 0; j<colunas; j++){
                    if(mat[i,j]==x){
                        
                        //um banho de logica nessa aula... 
                        
                        Console.WriteLine("Position " + i + "," + j + ":");
                        
                        if (j > 0) {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < colunas - 1) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < linhas - 1) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
