using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] valores = Console.ReadLine().Split(' ');
        int[] vetor = new int[n];
        int quantidadePares = 0;

        for (int i = 0; i < n; i++)
        {
            vetor[i] = int.Parse(valores[i]);
        }

        for (int i = 0; i < n; i++)
        {
            if (vetor[i] % 2 == 0)
            {
                Console.Write($"{vetor[i]} ");
                quantidadePares++;
            }
        }
        Console.WriteLine();
        Console.WriteLine(quantidadePares);
    }
}