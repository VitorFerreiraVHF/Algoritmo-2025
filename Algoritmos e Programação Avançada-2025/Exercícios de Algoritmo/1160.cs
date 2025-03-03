using System;

public class Program
{
    public static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int pa = int.Parse(valores[0]);
            int pb = int.Parse(valores[1]);
            double g1 = double.Parse(valores[2]);
            double g2 = double.Parse(valores[3]);

            int anos = 0;
            while (pa <= pb && anos <= 100)
            {
                pa += (int)(pa * (g1 / 100.0));
                pb += (int)(pb * (g2 / 100.0));
                anos++;
            }

            if (anos > 100)
            {
                Console.WriteLine("Mais de 1 seculo.");
            }
            else
            {
                Console.WriteLine($"{anos} anos.");
            }
        }
    }
}