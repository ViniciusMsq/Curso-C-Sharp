using System;

namespace Aula74_Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            //conversão de objeto tipo valor para referencia compativel
            Object obj = x;
            // conversão de um objeto tipo referência para um objeto tipo valor compatível
            int y = (int) obj;
        }
    }
}
