using System;

public class Program
{
    public static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');
        int a = int.Parse(valores[0]);
        int n = int.Parse(valores[1]);

        while (n <= 0)
        {
            n = int.Parse(Console.ReadLine());
        }

        int soma = 0;
        for (int i = 0; i < n; i++)
        {
            soma += a + i;
        }

        Console.WriteLine(soma);
    }
}