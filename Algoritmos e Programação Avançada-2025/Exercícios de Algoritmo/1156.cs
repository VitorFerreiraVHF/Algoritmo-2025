using System;

public class Program
{
    public static void Main(string[] args)
    {
        double s = 1.0;
        double numerador = 3.0;
        double denominador = 2.0;

        while (numerador <= 39.0)
        {
            s += numerador / denominador;
            numerador += 2.0;
            denominador *= 2.0;
        }

        Console.WriteLine(s.ToString("F2"));
    }
}