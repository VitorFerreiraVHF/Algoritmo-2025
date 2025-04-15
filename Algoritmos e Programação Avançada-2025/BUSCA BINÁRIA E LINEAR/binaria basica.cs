using System;

class Program
{
    static int PesquisaBinaria(int[] elementosOrdenados, int valorProcurado)
    {
        int limiteInferior = 0;
        int limiteSuperior = elementosOrdenados.Length - 1;

        while (limiteInferior <= limiteSuperior)
        {
            int indiceMediano = (limiteInferior + limiteSuperior) / 2;

            if (elementosOrdenados[indiceMediano] == valorProcurado)
            {
                return indiceMediano;
            }
            else if (elementosOrdenados[indiceMediano] < valorProcurado)
            {
                limiteInferior = indiceMediano + 1;
            }
            else
            {
                limiteSuperior = indiceMediano - 1;
            }
        }

        return -1;
    }

    static void Main()
    {
        int[] listaOrdenada = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        int valorBuscado = 7;

        int indiceEncontrado = PesquisaBinaria(listaOrdenada, valorBuscado);

        Console.WriteLine(indiceEncontrado != -1 ? $"Índice: {indiceEncontrado}" : "Número não encontrado");
    }
}