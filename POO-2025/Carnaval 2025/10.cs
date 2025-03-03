using System;

class Program {
    static void Main() {
        int[,] tabela = new int[4, 4];
        int totalSoma = 0;

        for (int linha = 0; linha < 4; linha++) {
            for (int coluna = 0; coluna < 4; coluna++) {
                tabela[linha, coluna] = int.Parse(Console.ReadLine());

                if (linha > coluna) {
                    totalSoma += tabela[linha, coluna];
                }
            }
        }

        Console.WriteLine($"Soma das áreas hachuradas: {totalSoma}");
    }
}
