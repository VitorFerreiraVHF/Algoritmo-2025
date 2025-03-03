using System;

class Program {
    static void Main() {
        Console.Write("Digite a altura: ");
        double alturaUsuario = double.Parse(Console.ReadLine());

        Console.Write("Informe o gênero (M/F): ");
        char genero = char.ToUpper(Console.ReadLine()[0]);

        double pesoCalculado = genero == 'M' ? (72.7 * alturaUsuario) - 58 : (62.1 * alturaUsuario) - 44.7;

        Console.WriteLine($"Peso recomendado: {pesoCalculado:F2}");
    }
}
