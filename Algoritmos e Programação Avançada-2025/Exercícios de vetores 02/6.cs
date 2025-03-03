using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string nomeMaisVelho = "";
        int idadeMaisVelha = 0;

        for (int i = 0; i < n; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            string nome = entrada[0];
            int idade = int.Parse(entrada[1]);

            if (i == 0 || idade > idadeMaisVelha)
            {
                nomeMaisVelho = nome;
                idadeMaisVelha = idade;
            }
        }

        Console.WriteLine($"Pessoa mais velha: {nomeMaisVelho}");
    }
}