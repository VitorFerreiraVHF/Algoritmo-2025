using System;
using System.Linq;

class Program {
    static void Main() {
        double[] pontuacoes = new double[7];

        for (int i = 0; i < 7; i++) {
            pontuacoes[i] = double.Parse(Console.ReadLine());
        }

        double notaFinal = pontuacoes.Sum() - pontuacoes.Max() - pontuacoes.Min();

        Console.WriteLine($"Nota final do atleta: {notaFinal:F2}");
    }
}
