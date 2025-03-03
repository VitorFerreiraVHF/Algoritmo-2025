using System;

class Program {
    static void Main() {
        Console.Write("Informe um número (1 a 7): ");
        int codigoDia = int.Parse(Console.ReadLine());

        string nomeDia = codigoDia switch {
            1 => "Domingo",
            2 => "Segunda-feira",
            3 => "Terça-feira",
            4 => "Quarta-feira",
            5 => "Quinta-feira",
            6 => "Sexta-feira",
            7 => "Sábado",
            _ => "Entrada inválida"
        };

        Console.WriteLine(nomeDia);
    }
}
