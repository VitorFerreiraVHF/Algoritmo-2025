using System;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int m = int.Parse(valores[0]);
            int n = int.Parse(valores[1]);

            if (m <= 0 || n <= 0)
            {
                break;
            }

            int menor = Math.Min(m, n);
            int maior = Math.Max(m, n);
            int soma = 0;

            for (int i = menor; i <= maior; i++)
            {
                Console.Write($"{i} ");
                soma += i;
            }

            Console.WriteLine($"Sum={soma}");
        }
    }
}