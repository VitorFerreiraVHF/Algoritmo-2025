using System;

public class Program
{
    public static void Main(string[] args)
    {
        int linhas = 3;
        int colunas = 5;
        int[,] matriz = new int[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < linhas; i++)
        {
            int somaLinha = 0;
            for (int j = 0; j < colunas; j++)
            {
                somaLinha += matriz[i, j];
            }
            Console.WriteLine($"Soma da linha {i + 1}: {somaLinha}");
        }
    }
}