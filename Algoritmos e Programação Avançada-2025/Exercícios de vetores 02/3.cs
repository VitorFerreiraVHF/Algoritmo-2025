using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] valoresA = Console.ReadLine().Split(' ');
        string[] valoresB = Console.ReadLine().Split(' ');
        int[] vetorA = new int[n];
        int[] vetorB = new int[n];
        int[] vetorC = new int[n];

        for (int i = 0; i < n; i++)
        {
            vetorA[i] = int.Parse(valoresA[i]);
            vetorB[i] = int.Parse(valoresB[i]);
            vetorC[i] = vetorA[i] + vetorB[i];
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{vetorC[i]} ");
        }
        Console.WriteLine();
    }
}