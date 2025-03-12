using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] vetor = { 26, 65, 45, 73, 10, 18, 78, 93, 70, 49, 23, 22 };
        int n = vetor.Length;

        for (int i = 1; i < n; i++)
        {
            int chave = vetor[i];
            int j = i - 1;

            while (j >= 0 && vetor[j] > chave)
            {
                vetor[j + 1] = vetor[j];
                j--;
            }
            vetor[j + 1] = chave;
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(vetor[i] + " ");
        }
    }
}