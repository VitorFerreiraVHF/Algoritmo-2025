using System;

class Program {
    static void Main() {
        Console.Write("Quantidade vendida por mês: ");
        int quantidade = int.Parse(Console.ReadLine());

        Console.Write("Valor atual do item: ");
        double valor = double.Parse(Console.ReadLine());

        if (quantidade < 500 && valor < 30) {
            valor *= 1.1;
        } else if (quantidade >= 500 && valor >= 30) {
            valor *= 0.8;
        }

        Console.WriteLine($"Novo valor: {valor:F2}");
    }
}
