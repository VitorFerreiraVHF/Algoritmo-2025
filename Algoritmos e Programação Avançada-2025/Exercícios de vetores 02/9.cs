using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int lucroAbaixo10 = 0;
        int lucroEntre10e20 = 0;
        int lucroAcima20 = 0;
        double valorTotalCompra = 0.0;
        double valorTotalVenda = 0.0;

        for (int i = 0; i < n; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            string nome = entrada[0];
            double precoCompra = double.Parse(entrada[1]);
            double precoVenda = double.Parse(entrada[2]);

            valorTotalCompra += precoCompra;
            valorTotalVenda += precoVenda;

            double lucro = (precoVenda - precoCompra) / precoCompra * 100.0;

            if (lucro < 10.0)
            {
                lucroAbaixo10++;
            }
            else if (lucro >= 10.0 && lucro <= 20.0)
            {
                lucroEntre10e20++;
            }
            else
            {
                lucroAcima20++;
            }
        }

        double lucroTotal = valorTotalVenda - valorTotalCompra;

        Console.WriteLine($"Lucro abaixo de 10%: {lucroAbaixo10}");
        Console.WriteLine($"Lucro entre 10% e 20%: {lucroEntre10e20}");
        Console.WriteLine($"Lucro acima de 20%: {lucroAcima20}");
        Console.WriteLine($"Valor total de compra: {valorTotalCompra:F2}");
        Console.WriteLine($"Valor total de venda: {valorTotalVenda:F2}");
        Console.WriteLine($"Lucro total: {lucroTotal:F2}");
    }
}