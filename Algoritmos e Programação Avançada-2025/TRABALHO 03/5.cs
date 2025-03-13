using System;

public class Program
{
    public static void Main(string[] args)
    {
        string[] nomesAlunos = new string[10];
        double[,] notasAlunos = new double[10, 3];
        double[] mediasAlunos = new double[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o nome do aluno {i + 1}: ");
            nomesAlunos[i] = Console.ReadLine();

            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Digite a nota {j + 1} do aluno {nomesAlunos[i]}: ");
                notasAlunos[i, j] = double.Parse(Console.ReadLine());
            }

            mediasAlunos[i] = (notasAlunos[i, 0] + notasAlunos[i, 1] + notasAlunos[i, 2]) / 3.0;
        }

        Console.WriteLine("\nRelatório de Alunos:");
        for (int i = 0; i < 10; i++)
        {
            if (mediasAlunos[i] >= 7.0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\nAluno: {nomesAlunos[i]}");
                Console.WriteLine($"Notas: {notasAlunos[i, 0]:F2}, {notasAlunos[i, 1]:F2}, {notasAlunos[i, 2]:F2}");
                Console.WriteLine($"Média: {mediasAlunos[i]:F2} - Aprovado");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nAluno: {nomesAlunos[i]}");
                Console.WriteLine($"Notas: {notasAlunos[i, 0]:F2}, {notasAlunos[i, 1]:F2}, {notasAlunos[i, 2]:F2}");
                Console.WriteLine($"Média: {mediasAlunos[i]:F2} - Reprovado");
            }
        }

        Console.ResetColor();
    }
}