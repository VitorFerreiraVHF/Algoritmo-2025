using System;

class Programa
{
    static (int maiorValor, int menorValor) ObterMaiorEMenorValor(int[] listaDeNumeros)
    {
        int maior = listaDeNumeros[0];
        int menor = listaDeNumeros[0];

        for (int i = 1; i < listaDeNumeros.Length; i++)
        {
            if (listaDeNumeros[i] > maior)
            {
                maior = listaDeNumeros[i];
            }
            if (listaDeNumeros[i] < menor)
            {
                menor = listaDeNumeros[i];
            }
        }

        return (maior, menor);
    }

    static void Main()
    {
        int[] valores = { 15, 3, 9, 8, 22, 5, 0 };
        var (maximo, minimo) = ObterMaiorEMenorValor(valores);

        Console.WriteLine($"Maior número: {maximo}");
        Console.WriteLine($"Menor número: {minimo}");
    }
}