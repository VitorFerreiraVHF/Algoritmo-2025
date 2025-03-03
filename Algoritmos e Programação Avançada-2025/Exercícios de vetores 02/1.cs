using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] valores = Console.ReadLine().Split(' ');
        double[] vetor = new double[n];

        for (int i = 0; i < n; i++)
        {
            vetor[i] = double.Parse(valores[i]);
        }

        double maior = vetor[0];
        int posicao = 0;

        for (int i = 1; i < n; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
                posicao = i;
            }
        }

        Console.WriteLine(maior);
        Console.WriteLine(posicao);
    }
}