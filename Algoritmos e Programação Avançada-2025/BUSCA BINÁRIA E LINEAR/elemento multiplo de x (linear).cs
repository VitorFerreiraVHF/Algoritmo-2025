using System;

class Programa
{
    static int ObterPrimeiroMultiplo(int[] listaDeNumeros, int divisor)
    {
        foreach (int numero in listaDeNumeros)
        {
            if (numero % divisor == 0)
            {
                return numero;
            }
        }
        return -1;
    }

    static void Main()
    {
        int[] valores = { 15, 22, 9, 8, 18, 5, 25 };
        int fator = 3;
        int primeiroMultiplo = ObterPrimeiroMultiplo(valores, fator);

        if (primeiroMultiplo != -1)
        {
            Console.WriteLine($"O primeiro múltiplo de {fator} encontrado é: {primeiroMultiplo}");
        }
        else
        {
            Console.WriteLine($"Nenhum múltiplo de {fator} foi encontrado.");
        }
    }
}