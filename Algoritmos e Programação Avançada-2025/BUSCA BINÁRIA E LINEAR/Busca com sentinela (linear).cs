using System;

class Program
{
    static int PesquisaSequencialComValorDeGuarda(int[] lista, int valorBuscado)
    {
        int tamanhoLista = lista.Length;
        int ultimoElemento = lista[tamanhoLista - 1];
        lista[tamanhoLista - 1] = valorBuscado;

        int indice = 0;
        while (lista[indice] != valorBuscado)
        {
            indice++;
        }

        lista[tamanhoLista - 1] = ultimoElemento;

        if (indice < tamanhoLista - 1)
        {
            return indice;
        }
        else
        {
            return -1;
        }
    }

    static void Main()
    {
        int[] numeros = { 15, 22, 9, 8, 5, 25, 7 };
        int valorProcurado = 8;
        int indiceEncontrado = PesquisaSequencialComValorDeGuarda(numeros, valorProcurado);

        if (indiceEncontrado != -1)
        {
            Console.WriteLine($"O número {valorProcurado} foi encontrado no índice {indiceEncontrado}");
        }
        else
        {
            Console.WriteLine("Número não encontrado");
        }
    }
}