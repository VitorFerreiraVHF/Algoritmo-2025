using System;

class Programa {
    static void Main() {
        Console.Write("O ser é um mamífero ou uma ave? (M/A): ");
        char grupoAnimal = char.ToUpper(Console.ReadLine()[0]);

        string especie = "";

        if (grupoAnimal == 'M') {
            Console.Write("O mamífero é quadrúpede, bípede, voador ou aquático? (Q/B/V/A): ");
            char tipoMamifero = char.ToUpper(Console.ReadLine()[0]);

            if (tipoMamifero == 'Q') {
                Console.Write("Ele é carnívoro ou herbívoro? (C/H): ");
                char tipoAlimentacao = char.ToUpper(Console.ReadLine()[0]);
                especie = tipoAlimentacao == 'C' ? "Leão" : "Cavalo";
            } else if (tipoMamifero == 'B') {
                Console.Write("Ele é onívoro ou frutífero? (O/F): ");
                char tipoDieta = char.ToUpper(Console.ReadLine()[0]);
                especie = tipoDieta == 'O' ? "Humano" : "Macaco";
            } else if (tipoMamifero == 'V') {
                especie = "Morcego";
            } else if (tipoMamifero == 'A') {
                especie = "Baleia";
            }
        } else if (grupoAnimal == 'A') {
            Console.Write("A ave é não-voadora, nadadora ou de rapina? (N/T/R): ");
            char tipoAve = char.ToUpper(Console.ReadLine()[0]);

            if (tipoAve == 'N') {
                Console.Write("Ela vive em região tropical ou polar? (T/P): ");
                char habitat = char.ToUpper(Console.ReadLine()[0]);
                especie = habitat == 'T' ? "Avestruz" : "Pinguim";
            } else if (tipoAve == 'T') {
                especie = "Pato";
            } else if (tipoAve == 'R') {
                especie = "Águia";
            }
        }

        Console.WriteLine($"O animal identificado é: {especie}");
    }
}
