using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);
            int soma = 0;
            int contador = 0;

            while (contador < y)
            {
                if (x % 2 != 0)
                {
                    soma += x;
                    contador++;
                }
                x++;
            }

            Console.WriteLine(soma);
        }
    }
}