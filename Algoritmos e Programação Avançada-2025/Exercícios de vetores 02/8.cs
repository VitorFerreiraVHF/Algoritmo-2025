using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double menorAltura = double.MaxValue;
        double maiorAltura = double.MinValue;
        double somaAlturasMulheres = 0.0;
        int quantidadeMulheres = 0;
        int quantidadeHomens = 0;

        for (int i = 0; i < n; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double altura = double.Parse(entrada[0]);
            char sexo = char.Parse(entrada[1]);

            if (altura < menorAltura)
            {
                menorAltura = altura;
            }
            if (altura > maiorAltura)
            {
                maiorAltura = altura;
            }

            if (sexo == 'F')
            {
                somaAlturasMulheres += altura;
                quantidadeMulheres++;
            }
            else if (sexo == 'M')
            {
                quantidadeHomens++;
            }
        }

        double mediaAlturasMulheres = quantidadeMulheres > 0 ? somaAlturasMulheres / quantidadeMulheres : 0.0;

        Console.WriteLine($"Menor altura = {menorAltura:F2}");
        Console.WriteLine($"Maior altura = {maiorAltura:F2}");
        Console.WriteLine($"Media das alturas das mulheres = {mediaAlturasMulheres:F2}");
        Console.WriteLine($"Numero de homens = {quantidadeHomens}");
    }
}