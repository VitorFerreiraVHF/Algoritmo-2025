using System;

class Program
{
    static int EncontrarMaiorMenorQueValor(int[] conjuntoNumeros, int valorReferencia)
    {
        int indiceInicial = 0;
        int indiceFinal = conjuntoNumeros.Length - 1;
        int maiorValorMenorQueReferencia = -1;

        while (indiceInicial <= indiceFinal)
        {
            int indiceMedio = (indiceInicial + indiceFinal) / 2;

            if (conjuntoNumeros[indiceMedio] < valorReferencia)
            {
                maiorValorMenorQueReferencia = conjuntoNumeros[indiceMedio];
                indiceInicial = indiceMedio + 1;
            }
            else
            {
                indiceFinal = indiceMedio - 1;
            }
        }

        return maiorValorMenorQueReferencia;
    }

    static void Main()
    {
        int[] numerosOrdenados = { 1, 3, 5, 7, 9, 11, 13, 15 };
        int valorDeBusca = 10;
        int resultadoDaBusca = EncontrarMaiorMenorQueValor(numerosOrdenados, valorDeBusca);

        if (resultadoDaBusca != -1)
        {
            Console.WriteLine($"O maior número menor que {valorDeBusca} é: {resultadoDaBusca}");
        }
        else
        {
            Console.WriteLine($"Não há número menor que {valorDeBusca}");
        }
    }
}