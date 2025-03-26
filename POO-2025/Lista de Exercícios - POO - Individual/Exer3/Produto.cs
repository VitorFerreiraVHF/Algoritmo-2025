using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer3
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeAtual { get; set; }
        public int Estoque { get; set; }

        public void AdicionarEstoque(int quantidade)
        {
            Estoque = QuantidadeAtual + quantidade;
            Console.WriteLine($"O estoque atual é de {Estoque}");
        }
        public void RemoverEstoque(int quantidade)
        {
            Estoque = QuantidadeAtual - quantidade;
            Console.WriteLine($"O estoque atual é de {Estoque}");
        }
        public void ExibirDetalhes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Quantidade Atual: {QuantidadeAtual}");
            Console.WriteLine($"Estoque: {Estoque}");
        }
    }
}