using System;

class Program {
    static void Main() {
        int[] respostasCorretas = new int[5];
        int[] apostaUsuario = new int[10];
        int acertos = 0;

        for (int i = 0; i < 5; i++) {
            respostasCorretas[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++) {
            apostaUsuario[i] = int.Parse(Console.ReadLine());
            if (Array.Exists(respostasCorretas, valor => valor == apostaUsuario[i])) {
                acertos++;
            }
        }

        Console.WriteLine($"Total de acertos: {acertos}");
    }
}
