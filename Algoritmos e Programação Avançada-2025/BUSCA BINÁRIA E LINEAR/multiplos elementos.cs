using System;
using System.Collections.Generic;

class Programa
{
    static List<int> ObterIndicesDeOcorrencias(int[] listaOrdenada, int valorProcurado)
    {
        List<int> indicesEncontrados = new List<int>();
        int limiteInferior = 0;
        int limiteSuperior = listaOrdenada.Length - 1;

        while (limiteInferior <= limiteSuperior)
        {
            int indiceMediano = (limiteInferior + limiteSuperior) / 2;

            if (listaOrdenada[indiceMediano] == valorProcurado)
            {
                indicesEncontrados.Add(indiceMediano);

                int esquerda = indiceMediano - 1;
                while (esquerda >= 0 && listaOrdenada[esquerda] == valorProcurado)
                {
                    indicesEncontrados.Add(esquerda);
                    esquerda--;
                }

                int direita = indiceMediano + 1;
                while (direita < listaOrdenada.Length && listaOrdenada[direita] == valorProcurado)
                {
                    indicesEncontrados.Add(direita);
                    direita++;
                }
                break;
            }
            else if (listaOrdenada[indiceMediano] < valorProcurado)
            {
                limiteInferior = indiceMediano + 1;
            }
            else
            {
                limiteSuperior = indiceMediano - 1;
            }
        }

        indicesEncontrados.Sort();
        return indicesEncontrados;
    }

    static void Main()
    {
        int[] dadosOrdenados = { 1, 3, 5, 5, 5, 7, 9, 11, 13, 15 };
        int valorBusca = 5;
        List<int> indices = ObterIndicesDeOcorrencias(dadosOrdenados, valorBusca);

        if (indices.Count > 0)
        {
            Console.WriteLine($"Ocorrências encontradas nos índices: {string.Join(", ", indices)}");
        }
        else
        {
            Console.WriteLine("Número não encontrado");
        }
    }
}