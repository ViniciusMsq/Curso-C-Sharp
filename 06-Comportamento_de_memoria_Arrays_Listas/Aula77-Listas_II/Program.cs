using System;
using System.Collections.Generic;
namespace Aula77_Listas_II
{
    class Program
    {
        static void Main(string[] args)
        {   
            //criando list
            List<string> list = new List<string>();

            //ADD colocando elementos na lista
            list.Add("Vinicius");
            list.Add("Mesquini");
            list.Add("De");
            list.Add("Oliveira");

            //Insert colonando elemento em posição determinada, empurra para baixo os elementos caso posição esteja ocupada
            list.Insert(2, "MESCHINI");

            //apresentando a lista
            foreach (string obj in list){
                Console.WriteLine(obj);
            }
            
            //Count Exibe quantidade da lista
            Console.WriteLine("LIST COUNT:"+ list.Count);

            //Find espera um predicado,busca o primeiro eleemento com base no
            //retorno de função condicional, pode ser feito por função anonima(lambda)
            //aqui ele está buscando o primeiro elemento que começa com M
            string s1 = list.Find(x => x[0] == 'M' );
            Console.WriteLine("FIRST 'M': " + s1);
            
            //FindLast aqui ele está buscando o ultimo elemento que começa com M
            string s2 = list.FindLast(x => x[0] == 'M' );
            Console.WriteLine("FIRST LAST 'M': " + s2);

            //FindIndex, busca a posição do primeiro elemento com base na condição
            int pos1 = list.FindIndex(x => x[0]=='M');
            Console.WriteLine("FIRS Index 'M': " + pos1);
            
            //FindLastIndex, busca a posição do ultimo elemento com base na condição
            int pos2 = list.FindLastIndex(x => x[0]=='M');
            Console.WriteLine("FIRS LAST Index 'M': " + pos2);

            //FindAll filtra todos os elementos que tem a mesma condição
            //criando uma list2 nova e colocando nela todos os elementos que tem mais 5 caracteres na list
            List<string> list2 = list.FindAll(x => x.Length > 5);
            Console.WriteLine("-------------------------------------");

            foreach(string obj in list2){
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------------");

            //Remove o elemento da list
            list.Remove("MESCHINI");
            foreach (string obj in list){
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------------");

            //RemoveALL remove todos os elementos que batem com a condição 
            list.RemoveAll( x=> x[0] == 'M');

            foreach (string obj in list){
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------------");
            //RemoveAt remove o elemento com base na posição
            list.RemoveAt(1);

            foreach (string obj in list){
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------------");
            //RemoveRage elimina uma faixa de elementos, com base no indice inicial passado, e a quantidaed de elementos a remover
            list.RemoveRange(1,1);

            foreach (string obj in list){
                Console.WriteLine(obj);
            }
        }


    }
}
