using System;

public class Program
{
    public static void Main(string[] args)
    {
        int x = 10;
        int jBase = 7;
        int incrementoJ = 2;

        for (int i = 1; i < x; i += 2)
        {
            int j = jBase;
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine($"I={i} J={j}");
                j--;
            }
            jBase += incrementoJ;
        }
    }
}