namespace Aula60
{
    public class Banco
    {
        public string Nome{get; set;}
        public int NumeroDaConta{get; private set;}
        public double Valor{get; private set;}

        public Banco(int numeroDaConta, string nome){
            NumeroDaConta = numeroDaConta;
            Nome = nome;
        }
        public Banco(int numeroDaConta, string nome, double valor) : this (numeroDaConta, nome){
            Depositar(valor);
        }
        public void Depositar(double valor){
            Valor += valor;
        }
        public void Saque(double valor){
            Valor -= (valor + 5);
        }
        public override string ToString(){
            return "Conta " + NumeroDaConta + ", Titular: " + Nome + ", Saldo: $ " + Valor.ToString("F2");
        }
        
    }
}