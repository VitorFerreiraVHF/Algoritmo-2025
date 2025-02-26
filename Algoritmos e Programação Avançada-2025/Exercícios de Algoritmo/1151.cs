using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int primeiro = 0;
        int segundo = 1;

        if (n > 0)
        {
            Console.Write(primeiro);
        }

        if (n > 1)
        {
            Console.Write(" " + segundo);
        }

        for (int i = 2; i < n; i++)
        {
            int proximo = primeiro + segundo;
            Console.Write(" " + proximo);
            primeiro = segundo;
            segundo = proximo;
        }

        Console.WriteLine();
    }
}