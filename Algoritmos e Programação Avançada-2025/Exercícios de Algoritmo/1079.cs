using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double a = double.Parse(valores[0]);
            double b = double.Parse(valores[1]);
            double c = double.Parse(valores[2]);

            double media = (a * 2 + b * 3 + c * 5) / 10;
            Console.WriteLine(media.ToString("F1"));
        }
    }
}