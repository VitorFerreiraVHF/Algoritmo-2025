using System;

class Programa
{
    static int CalcularFrequencia(int[] listaDeNumeros, int numeroAlvo)
    {
        int frequencia = 0;

        foreach (int numero in listaDeNumeros)
        {
            if (numero == numeroAlvo)
            {
                frequencia++;
            }
        }

        return frequencia;
    }

    static void Main()
    {
        int[] dados = { 1, 3, 5, 7, 9, 7, 11, 7, 13, 15 };
        int valorParaContar = 7;
        int totalOcorrencias = CalcularFrequencia(dados, valorParaContar);

        if (totalOcorrencias > 0)
        {
            Console.WriteLine($"O número {valorParaContar} aparece {totalOcorrencias} vez(es) no array.");
        }
        else
        {
            Console.WriteLine($"O número {valorParaContar} não foi encontrado no array.");
        }
    }
}