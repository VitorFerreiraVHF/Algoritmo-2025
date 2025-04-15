using System;

class Programa
{
    static int ObterUltimoIndice(int[] listaOrdenada, int valorProcurado)
    {
        int indiceInicial = 0;
        int indiceFinal = listaOrdenada.Length - 1;
        int ultimoIndiceEncontrado = -1;

        while (indiceInicial <= indiceFinal)
        {
            int indiceMediano = (indiceInicial + indiceFinal) / 2;

            if (listaOrdenada[indiceMediano] == valorProcurado)
            {
                ultimoIndiceEncontrado = indiceMediano;
                indiceInicial = indiceMediano + 1;
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

        return ultimoIndiceEncontrado;
    }

    static void Main()
    {
        int[] dadosOrdenados = { 1, 2, 2, 2, 3, 4, 5, 6 };
        int valorBusca = 2;
        int posicaoFinal = ObterUltimoIndice(dadosOrdenados, valorBusca);

        if (posicaoFinal != -1)
        {
            Console.WriteLine($"A última ocorrência do número {valorBusca} está na posição {posicaoFinal}");
        }
        else
        {
            Console.WriteLine("Número não encontrado");
        }
    }
}