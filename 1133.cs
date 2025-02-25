using System;

public class Program
{
    public static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');
        int x = int.Parse(valores[0]);
        int y = int.Parse(valores[1]);

        if (x > y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        for (int i = x + 1; i < y; i++)
        {
            if (i % 5 == 2 || i % 5 == 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}