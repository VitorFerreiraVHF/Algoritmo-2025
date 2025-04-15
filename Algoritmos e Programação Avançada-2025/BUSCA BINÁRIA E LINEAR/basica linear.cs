using System;

class Program
{
    static int PesquisarElemento(int[] elementos, int elementoProcurado)
    {
        for (int i = 0; i < elementos.Length; i++)
        {
            if (elementos[i] == elementoProcurado)
            {
                return i;
            }
        }
        return -1;
    }

    static void Main()
    {
        int[] listaDeElementos = { 1, 3, 5, 7, 9, 11, 13, 15 };
        int valorBuscado = 7;
        int indiceEncontrado = PesquisarElemento(listaDeElementos, valorBuscado);

        if (indiceEncontrado != -1)
        {
            Console.WriteLine($"O número {valorBuscado} foi encontrado no índice {indiceEncontrado}");
        }
        else
        {
            Console.WriteLine("Número não encontrado");
        }
    }
}