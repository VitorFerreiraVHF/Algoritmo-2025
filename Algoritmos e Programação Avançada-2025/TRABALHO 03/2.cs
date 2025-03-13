using System;

public class Program
{
    public static void Main(string[] args)
    {
        string[] nomesProdutos = new string[10];
        double[] precosProdutos = new double[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o nome do produto {i + 1}: ");
            nomesProdutos[i] = Console.ReadLine();

            Console.Write($"Digite o preço do produto {i + 1}: ");
            precosProdutos[i] = double.Parse(Console.ReadLine());
        }

        Console.Write("Digite o valor máximo para pesquisa: ");
        double valorMaximo = double.Parse(Console.ReadLine());

        Console.WriteLine("\nProdutos com preço até R$" + valorMaximo + ":");
        for (int i = 0; i < 10; i++)
        {
            if (precosProdutos[i] <= valorMaximo)
            {
                Console.WriteLine($"- {nomesProdutos[i]}: R$ {precosProdutos[i]:F2}");
            }
        }
    }
}