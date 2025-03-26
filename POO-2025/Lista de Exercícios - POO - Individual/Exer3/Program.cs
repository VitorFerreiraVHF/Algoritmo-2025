using Exercicio3;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Produto _produto = new Produto();

        Console.WriteLine("Insira o Nome:");
        _produto.Nome = Console.ReadLine();
        Console.WriteLine("Insira o Preço:");
        _produto.Preco = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira a Quantidade Atual:");
        _produto.QuantidadeAtual = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o Estoque:");
        _produto.Estoque = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira a quantidade a ser adicionada ao estoque:");
        int adicionarQuantidade = int.Parse(Console.ReadLine());
        _produto.AdicionarEstoque(adicionarQuantidade);

        Console.WriteLine("Insira a quantidade a ser removida do estoque:");
        int removerQuantidade = int.Parse(Console.ReadLine());
        _produto.RemoverEstoque(removerQuantidade);

        _produto.ExibirDetalhes();
    }
}