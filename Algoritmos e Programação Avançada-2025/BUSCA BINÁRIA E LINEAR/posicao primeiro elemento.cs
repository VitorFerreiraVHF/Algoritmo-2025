using System;

class Programa
{
    static int ObterPrimeiroIndice(int[] listaOrdenada, int valorProcurado)
    {
        int indiceInicial = 0;
        int indiceFinal = listaOrdenada.Length - 1;
        int primeiroIndiceEncontrado = -1;

        while (indiceInicial <= indiceFinal)
        {
            int indiceMediano = (indiceInicial + indiceFinal) / 2;

            if (listaOrdenada[indiceMediano] == valorProcurado)
            {
                primeiroIndiceEncontrado = indiceMediano;
                indiceFinal = indiceMediano - 1;
            }
            else if (listaOrdenada[indiceMediano] < valorProcurado)
            {
                indiceInicial = indiceMediano + 1;
            }
            else
            {
                indiceFinal = indiceMediano - 1;
            }
        }

        return primeiroIndiceEncontrado;
    }

    static void Main()
    {
        int[] dadosOrdenados = { 1, 2, 2, 2, 3, 4, 5, 6 };
        int valorBusca = 2;
        int posicaoInicial = ObterPrimeiroIndice(dadosOrdenados, valorBusca);

        if (posicaoInicial != -1)
        {
            Console.WriteLine($"A primeira ocorrência do número {valorBusca} está na posição {posicaoInicial}");
        }
        else
        {
            Console.WriteLine("Número não encontrado");
        }
    }
}