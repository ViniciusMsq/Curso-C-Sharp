using System;

namespace Aula45ex2
{
    public class Funcionario
    {
        private string _nome;
        private double _SalarioBruto, _Imposto;

        public string Nome{
            get => _nome;
            set => _nome = value;
        }
        public double Salario{
            get => _SalarioBruto;
            set => _SalarioBruto = value;
        }
        public double Imposto{
            get { return _Imposto;}
            set {
                if(value>0){
                    _Imposto = value;
                    }
            }
        }
        public double SalarioLiquido(){
            return _SalarioBruto - _Imposto;
        }
        public void AumentarSalario(double porcentagem){
            _SalarioBruto += (_SalarioBruto*0.10); 
        }
        public override string ToString(){
            return _nome + ", $ " + SalarioLiquido().ToString("F2"); 
        } 
    }
}