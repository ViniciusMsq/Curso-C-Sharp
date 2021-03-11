using System;
using System.Collections.Generic;

namespace Aula78_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string nome;
            double salario;

            List<Employees> list = new List<Employees>();

            Console.Write("Quantos funcionarios vai registrar? ");
            int qtd = int.Parse(Console.ReadLine());

            for(int i = 0; i<qtd; i++){
                Console.WriteLine("Funcionário #{0}:", (i+1));
                do{
                    Console.Write("ID: ");
                    id = int.Parse(Console.ReadLine());
                    if(list.Find(x => x.Id == id)!= null){
                        Console.WriteLine("Este Id ja estpa sendo usado!\n\nTente novamente:");
                        Console.ReadKey();
                    }
                }while(list.Find(x => x.Id == id)!= null);
                Console.Write("NOME: ");
                nome = Console.ReadLine();
                Console.Write("SALÁRIO: ");
                salario = double.Parse(Console.ReadLine());
                Console.WriteLine();
                list.Add(new Employees(id, nome, salario));
            }

            Console.Write("Entre com o Id de quem terá o salario aumentado: ");
            int increass = int.Parse(Console.ReadLine());
            
            if(list.Find(x => x.Id == increass)!= null){
                Console.Write("Entre com a porcentagem de aumento: ");
                double porcentage = double.Parse(Console.ReadLine());

                int x = list.FindIndex(x => x.Id == increass);
            
                list[x].Aumento(porcentage);
            }
            else{
                Console.WriteLine("o Id não existe!");
            }

            Console.WriteLine("\nUpdate list of employees: ");
            foreach(Employees obj in list){
                Console.WriteLine(obj);
            }

        }
    }
}
