using System;

class Program {
    static void Main() {
        double resultado = 0;
        for (int indice = 1; indice <= 10; indice++) {
            resultado += 1.0 / indice;
        }
        Console.WriteLine($"Valor de S: {resultado:F2}");
    }
}
