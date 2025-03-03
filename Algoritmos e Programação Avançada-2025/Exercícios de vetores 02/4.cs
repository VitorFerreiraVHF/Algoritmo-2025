using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] valores = Console.ReadLine().Split(' ');
        double[] vetor = new double[n];
        double soma = 0.0;

        for (int i = 0; i < n; i++)
        {
            vetor[i] = double.Parse(valores[i]);
            soma += vetor[i];
        }

        double media = soma / n;
        Console.WriteLine(media.ToString("F3"));

        for (int i = 0; i < n; i++)
        {
            if (vetor[i] < media)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}