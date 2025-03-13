using System;

public class Program
{
    public static void Main(string[] args)
    {
        int tamanhoVetor = 15;
        int[] vetor = LerVetor(tamanhoVetor);
        ExibirElementosPares(vetor);
    }

    public static int[] LerVetor(int tamanho)
    {
        int[] vetor = new int[tamanho];
        for (int i = 0; i < tamanho; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }
        return vetor;
    }

    public static void ExibirElementosPares(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i += 2)
        {
            Console.WriteLine(vetor[i]);
        }
    }
}