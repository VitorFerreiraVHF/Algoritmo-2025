using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int contador = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{contador} {contador + 1} {contador + 2} PUM");
            Console.WriteLine();
            contador += 4;
        }
    }
}