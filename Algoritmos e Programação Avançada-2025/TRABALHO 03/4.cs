using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[,] matriz = new int[5, 5];
        int numero = 1;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matriz[i, j] = numero++;
            }
        }

        Console.WriteLine("Diagonal Principal:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(matriz[i, i] + " ");
        }

        Console.WriteLine("\nDiagonal Secundária:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(matriz[i, 4 - i] + " ");
        }
    }
}