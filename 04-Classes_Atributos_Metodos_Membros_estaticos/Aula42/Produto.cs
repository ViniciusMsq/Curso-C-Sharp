using System;

namespace Aula42
{
    public class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public string Nome{
            get => _nome;
            set => _nome = value;
        }
        public double Preco{
            get => _preco;
            set => _preco = value;
        }
        public int Quantidade{
            get => _quantidade;
            set => _quantidade = value;
        }
        public double ValorTotalEmEstoque(){
            return _quantidade * _preco;
        }
        public void AdicionarProdutos(int quantity){
            _quantidade += quantity;
        }
        public void RemoverProdutos(int quantity){
            _quantidade -= quantity;
        }
        public override string ToString(){
            return "Dados do produto: " + _nome + ", $ " + _preco.ToString("F2") + ", "+ _quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2");
        } 
    }
}