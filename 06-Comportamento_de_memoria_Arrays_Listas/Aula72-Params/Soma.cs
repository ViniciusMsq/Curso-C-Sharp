namespace Aula72
{
    public class Soma
    {
        // params ja indica que vai conter quantidade varivavel de valores, então não precisa instanciar como vetor
        public static int Sum(params int[] vet){
            int soma = 0;

            for(int i = 0; i < vet.Length; i++){
                soma += vet[i];
            }
            return soma;
        }
    }
}