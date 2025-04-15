using System;

class Programa
{
    static bool ContemElemento(int[] listaOrdenada, int elementoProcurado)
    {
        int limiteInferior = 0;
        int limiteSuperior = listaOrdenada.Length - 1;

        while (limiteInferior <= limiteSuperior)
        {
            int indiceMediano = (limiteInferior + limiteSuperior) / 2;

            if (listaOrdenada[indiceMediano] == elementoProcurado) return true;
            if (listaOrdenada[indiceMediano] < elementoProcurado) limiteInferior = indiceMediano + 1;
            else limiteSuperior = indiceMediano - 1;
        }

        return false;
    }

    static void Main()
    {
        int[] dadosOrdenados = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        Console.WriteLine(ContemElemento(dadosOrdenados, 7) ? "Número encontrado" : "Número não encontrado");
    }
}