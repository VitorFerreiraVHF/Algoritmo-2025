using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] valores = Console.ReadLine().Split(' ');
        int[] vetor = new int[n];
        int somaPares = 0;
        int quantidadePares = 0;

        for (int i = 0; i < n; i++)
        {
            vetor[i] = int.Parse(valores[i]);
            if (vetor[i] % 2 == 0)
            {
                somaPares += vetor[i];
                quantidadePares++;
            }
        }

        double mediaPares = (double)somaPares / quantidadePares;
        Console.WriteLine(mediaPares.ToString("F1"));
    }
}