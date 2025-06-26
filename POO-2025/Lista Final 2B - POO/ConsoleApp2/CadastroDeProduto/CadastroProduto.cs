using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Produto
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }
    }

    static List<Produto> produtos = new List<Produto>();

    static void Main(string[] args)
    {
        bool executando = true;

        while (executando)
        {
            ExibirMenu();
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarProduto();
                    break;
                case "2":
                    RemoverProduto();
                    break;
                case "3":
                    PesquisarProduto();
                    break;
                case "4":
                    MostrarMenorValor();
                    break;
                case "5":
                    executando = false;
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void ExibirMenu()
    {
        Console.Clear();
        Console.WriteLine("1. Cadastrar produto");
        Console.WriteLine("2. Remover produto");
        Console.WriteLine("3. Pesquisar produto");
        Console.WriteLine("4. Mostrar produto com menor valor");
        Console.WriteLine("5. Sair");
        Console.Write("Escolha uma opção: ");
    }

    static void CadastrarProduto()
    {
        Console.Clear();
        Console.WriteLine("=== Cadastro de Produto ===");

        Produto novoProduto = new Produto();

        Console.Write("Descrição do produto: ");
        novoProduto.Descricao = Console.ReadLine();

        Console.Write("Valor do produto: ");
        if (double.TryParse(Console.ReadLine(), out double valor))
        {
            novoProduto.Valor = valor;
            produtos.Add(novoProduto);
            Console.WriteLine("\nProduto cadastrado com sucesso!");
        }
        else
        {
            Console.WriteLine("\nValor inválido. O produto não foi cadastrado.");
        }
    }

    static void RemoverProduto()
    {
        Console.Clear();
        Console.WriteLine("Remover Produto");

        Console.Write("Digite a descrição do produto a ser removido: ");
        string descricao = Console.ReadLine();

        Produto produtoParaRemover = produtos.FirstOrDefault(p => p.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase));

        if (produtoParaRemover != null)
        {
            produtos.Remove(produtoParaRemover);
            Console.WriteLine("\nProduto removido com sucesso!");
        }
        else
        {
            Console.WriteLine("\nProduto não encontrado.");
        }
    }

    static void PesquisarProduto()
    {
        Console.Clear();
        Console.WriteLine("Pesquisar Produto");

        Console.Write("Digite a descrição do produto a ser pesquisado: ");
        string descricao = Console.ReadLine();

        Produto produtoEncontrado = produtos.FirstOrDefault(p => p.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase));

        if (produtoEncontrado != null)
        {
            Console.WriteLine("\nProduto encontrado:");
            Console.WriteLine($"Descrição: {produtoEncontrado.Descricao}");
            Console.WriteLine($"Valor: {produtoEncontrado.Valor:C}");
        }
        else
        {
            Console.WriteLine("\nProduto não encontrado.");
        }
    }

    static void MostrarMenorValor()
    {
        Console.Clear();
        Console.WriteLine("Produto com Menor Valor");

        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
            return;
        }

        Produto menorValor = produtos.OrderBy(p => p.Valor).First();

        Console.WriteLine("Produto com menor valor:");
        Console.WriteLine($"Descrição: {menorValor.Descricao}");
        Console.WriteLine($"Valor: {menorValor.Valor:C}");
    }
}