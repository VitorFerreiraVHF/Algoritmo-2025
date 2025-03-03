using System;

class Program {
    static void Main() {
        Console.Write("Horas no mês: ");
        int horasTrabalho = int.Parse(Console.ReadLine());

        Console.Write("Valor pago por hora: ");
        double valorHora = double.Parse(Console.ReadLine());

        int cargaHoraria = Math.Min(horasTrabalho, 160);
        int extras = Math.Max(horasTrabalho - 160, 0);

        double totalRecebido = (cargaHoraria * valorHora) + (extras * valorHora * 1.5);

        Console.WriteLine($"Salário final: {totalRecebido:F2}");
    }
}
