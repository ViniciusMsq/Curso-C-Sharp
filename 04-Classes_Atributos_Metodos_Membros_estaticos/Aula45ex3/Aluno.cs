namespace Aula45ex3
{
    public class Aluno
    {
        public string nome;
        public double nota1, nota2, nota3;

        public double NotaFinal(){
            return nota1+nota2+nota3;
        }
        public string Aprovado(double nota){
            if(nota >=60){
                return "APROVADO";
            }else{
                nota = 60 - nota;
                return "REPROVADO\nFaltaram " + nota.ToString("F2") + " pontos";
            }
        }
    }
}