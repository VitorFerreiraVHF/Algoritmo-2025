using System;

public class Program
{
    public static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());

        while (z <= x)
        {
            z = int.Parse(Console.ReadLine());
        }

        int soma = x;
        int contador = 1;
        int proximo = x + 1;

        while (soma <= z)
        {
            soma += proximo;
            proximo++;
            contador++;
        }

        Console.WriteLine(contador);
    }
}