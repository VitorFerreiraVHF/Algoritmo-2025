using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] vetor = { 26, 65, 45, 73, 10, 18, 78, 93, 70, 49, 23, 22 };
        BubbleSort(vetor);

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
    }

    public static void BubbleSort(int[] vetor)
    {
        int n = vetor.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (vetor[j] > vetor[j + 1])
                {
                    Trocar(vetor, j, j + 1);
                }
            }
        }
    }

    public static void Trocar(int[] vetor, int i, int j)
    {
        int temp = vetor[i];
        vetor[i] = vetor[j];
        vetor[j] = temp;
    }
}