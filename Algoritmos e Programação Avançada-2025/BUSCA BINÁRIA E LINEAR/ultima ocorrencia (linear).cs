using System;

class Programa
{
    static int ObterIndiceDaUltimaOcorrencia(int[] listaDeNumeros, int valorProcurado)
    {
        int ultimoIndice = -1;

        for (int i = 0; i < listaDeNumeros.Length; i++)
        {
            if (listaDeNumeros[i] == valorProcurado)
            {
                ultimoIndice = i;
            }
        }
        return ultimoIndice;
    }

    static void Main()
    {
        int[] valores = { 15, 22, 9, 8, 22, 5, 25, 22 };
        int valorBusca = 22;
        int indiceFinal = ObterIndiceDaUltimaOcorrencia(valores, valorBusca);

        if (indiceFinal != -1)
        {
            Console.WriteLine($"A última ocorrência de {valorBusca} está no índice {indiceFinal}");
        }
        else
        {
            Console.WriteLine("Número não encontrado");
        }
    }
}