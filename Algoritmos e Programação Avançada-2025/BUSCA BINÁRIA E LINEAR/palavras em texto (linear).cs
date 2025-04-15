using System;

class Programa
{
    static int EncontrarPosicaoDaPalavra(string textoPrincipal, string palavraProcurada)
    {
        return textoPrincipal.IndexOf(palavraProcurada);
    }

    static void Main()
    {
        Console.WriteLine("Digite um texto:");
        string textoDigitado = Console.ReadLine();

        Console.WriteLine("Digite a palavra a ser buscada:");
        string palavraBusca = Console.ReadLine();

        int posicaoEncontrada = EncontrarPosicaoDaPalavra(textoDigitado, palavraBusca);

        if (posicaoEncontrada != -1)
        {
            Console.WriteLine($"A palavra foi encontrada na posição: {posicaoEncontrada}");
        }
        else
        {
            Console.WriteLine("A palavra não foi encontrada.");
        }
    }
}