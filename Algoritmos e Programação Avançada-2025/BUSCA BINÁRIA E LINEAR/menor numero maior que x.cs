using System;

class Programa
{
    static int ObterMenorMaiorQueValor(int[] listaNumeros, int valorLimite)
    {
        int indiceInicial = 0;
        int indiceFinal = listaNumeros.Length - 1;
        int menorMaior = -1;

        while (indiceInicial <= indiceFinal)
        {
            int indiceMedio = (indiceInicial + indiceFinal) / 2;

            if (listaNumeros[indiceMedio] > valorLimite)
            {
                menorMaior = listaNumeros[indiceMedio];
                indiceFinal = indiceMedio - 1;
            }
            else
            {
                indiceInicial = indiceMedio + 1;
            }
        }

        return menorMaior;
    }

    static void Main()
    {
        int[] numerosOrdenados = { 1, 3, 5, 7, 9, 11, 13, 15 };
        int valorDeComparacao = 10;
        int resultadoBusca = ObterMenorMaiorQueValor(numerosOrdenados, valorDeComparacao);

        if (resultadoBusca != -1)
        {
            Console.WriteLine($"O menor número maior que {valorDeComparacao} é: {resultadoBusca}");
        }
        else
        {
            Console.WriteLine($"Não há número maior que {valorDeComparacao}");
        }
    }
}