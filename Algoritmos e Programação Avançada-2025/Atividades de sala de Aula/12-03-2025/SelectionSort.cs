using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] vetor = { 26, 65, 45, 73, 10, 18, 78, 93, 70, 49, 23, 22 };
        int n = vetor.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int indiceMenor = i;
            for (int j = i + 1; j < n; j++)
            {
                if (vetor[j] < vetor[indiceMenor])
                {
                    indiceMenor = j;
                }
            }
            int temp = vetor[indiceMenor];
            vetor[indiceMenor] = vetor[i];
            vetor[i] = temp;
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(vetor[i] + " ");
        }
    }
}