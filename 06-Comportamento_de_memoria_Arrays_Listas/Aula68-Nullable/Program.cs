using System;

namespace Aula68_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //  "?"= define possibilidade de null no tipo valor
            double? x = null;
            double? y = 10.0;
            
            // pega o valor ou se for null, o valor padrão do tipo
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            
            //vefica se tem valor: sim=true, null=false
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            
            if (x.HasValue){
                // imprime o valor se tiver
                Console.WriteLine(x.Value);
            }else{
                Console.WriteLine("X is null");
            }
            if (y.HasValue){
                Console.WriteLine(y.Value);
            }else{
                Console.WriteLine("Y is null");
            }

            // "??" caso o valor da variavel seja nulo coloca o valor padrão escolhido
            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine("A:{0}, B:{1}", a , b);
        }
    }
}
