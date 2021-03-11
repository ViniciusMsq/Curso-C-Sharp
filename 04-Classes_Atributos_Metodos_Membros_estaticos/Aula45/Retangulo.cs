using System;

namespace Aula45
{
    public class Retangulo
    {
        private double _largura, _altura;

        public double Lagura{
            get => _largura;
            set => _largura = value;
        }
        public double Altura{
            get => _altura;
            set => _altura = value;
        }

        public double Area(){
            return _altura * _largura;
        }
        public double Perimetro(){
            return (2*_altura) + (2*_largura);
        }
        public double Diagonal(){
            return Math.Sqrt(Math.Pow(_altura, 2) + Math.Pow(_largura, 2));
        }
    }
}