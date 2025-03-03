using System;
using System.Linq;

class Program {
    static void Main() {
        int[] valores = new int[20];

        for (int i = 0; i < 20; i++) {
            valores[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Informe um número limite: ");
        int limite = int.Parse(Console.ReadLine());

        var resultado = valores.Where(x => x > limite).ToArray();

        Console.WriteLine(string.Join(" ", resultado));
    }
}
