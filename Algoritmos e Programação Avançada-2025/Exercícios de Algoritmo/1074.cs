using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());

            if (x == 0)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                string parImpar = (x % 2 == 0) ? "EVEN" : "ODD";
                string positivoNegativo = (x > 0) ? "POSITIVE" : "NEGATIVE";
                Console.WriteLine($"{parImpar} {positivoNegativo}");
            }
        }
    }
}