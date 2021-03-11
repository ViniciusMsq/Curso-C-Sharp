namespace Aula78_Exercicio
{
    public class Employees
    {
        public int Id{get; private set;}
        private string Nome{get; set;}
        private double Salario{get; set;}

        public Employees(int id, string nome, double salario){
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void Aumento(double porcentage){
            Salario += (Salario*(porcentage/100));
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2");  
        }
    }
}