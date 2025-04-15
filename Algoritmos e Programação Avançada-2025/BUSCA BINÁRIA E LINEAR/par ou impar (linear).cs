using System;

class Programa
{
    static int ObterPrimeiroNumeroPar(int[] listaDeNumeros)
    {
        foreach (int numero in listaDeNumeros)
        {
            if (numero % 2 == 0)
            {
                return numero;
            }
        }
        return -1;
    }

    static void Main()
    {
        int[] valores = { 15, 22, 9, 8, 5, 25, 7 };
        int primeiroPar = ObterPrimeiroNumeroPar(valores);

        if (primeiroPar != -1)
        {
            Console.WriteLine($"O primeiro número par encontrado é: {primeiroPar}");
        }
        else
        {
            Console.WriteLine("Nenhum número par encontrado");
        }
    }
}