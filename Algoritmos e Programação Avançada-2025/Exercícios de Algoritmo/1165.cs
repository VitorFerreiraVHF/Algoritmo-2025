using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            bool primo = true;

            if (x <= 1)
            {
                primo = false;
            }
            else
            {
                for (int j = 2; j <= Math.Sqrt(x); j++)
                {
                    if (x % j == 0)
                    {
                        primo = false;
                        break;
                    }
                }
            }

            if (primo)
            {
                Console.WriteLine($"{x} eh primo");
            }
            else
            {
                Console.WriteLine($"{x} nao eh primo");
            }
        }
    }
}