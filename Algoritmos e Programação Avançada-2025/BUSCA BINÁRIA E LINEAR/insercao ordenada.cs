using System;

class Programa
{
    static int ObterIndiceDeInsercao(int[] listaOrdenada, int valorParaInserir)
    {
        int limiteInferior = 0;
        int limiteSuperior = listaOrdenada.Length;

        while (limiteInferior < limiteSuperior)
        {
            int indiceMediano = (limiteInferior + limiteSuperior) / 2;

            if (listaOrdenada[indiceMediano] < valorParaInserir)
            {
                limiteInferior = indiceMediano + 1;
            }
            else
            {
                limiteSuperior = indiceMediano;
            }
        }

        return limiteInferior;
    }

    static void Main()
    {
        int[] dadosOrdenados = { 1, 3, 5, 7, 9, 11 };
        int valorInsercao = 6;
        int posicaoDeInsercao = ObterIndiceDeInsercao(dadosOrdenados, valorInsercao);

        Console.WriteLine($"O número {valorInsercao} deve ser inserido na posição {posicaoDeInsercao}");
    }
}