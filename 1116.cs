using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string linha = Console.ReadLine();
            string[] valores = linha.Split(' ');
            double numerador = Convert.ToDouble(valores[0]);
            double denominador = Convert.ToDouble(valores[1]);

            if (denominador == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                double resultado = numerador / denominador;
                Console.WriteLine(resultado.ToString("F1"));
            }
        }
    }
}