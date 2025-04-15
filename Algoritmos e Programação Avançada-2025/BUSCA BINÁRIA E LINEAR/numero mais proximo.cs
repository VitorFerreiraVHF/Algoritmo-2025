using System;

class Programa
{
    static int ObterNumeroMaisProximo(int[] listaOrdenada, int valorAlvo)
    {
        int indiceInicial = 0;
        int indiceFinal = listaOrdenada.Length - 1;
        int indiceMaisProximo = 0;
        int menorDiferenca = int.MaxValue;

        while (indiceInicial <= indiceFinal)
        {
            int indiceMediano = (indiceInicial + indiceFinal) / 2;
            int diferencaAtual = Math.Abs(listaOrdenada[indiceMediano] - valorAlvo);

            if (diferencaAtual < menorDiferenca)
            {
                menorDiferenca = diferencaAtual;
                indiceMaisProximo = indiceMediano;
            }

            if (listaOrdenada[indiceMediano] == valorAlvo)
            {
                return listaOrdenada[indiceMediano];
            }
            else if (listaOrdenada[indiceMediano] < valorAlvo)
            {
                indiceInicial = indiceMediano + 1;
            }
            else
            {
                indiceFinal = indiceMediano - 1;
            }
        }

        return listaOrdenada[indiceMaisProximo];
    }

    static void Main()
    {
        int[] numerosOrdenados = { 1, 3, 5, 7, 9, 11, 13, 15 };
        int valorDeBusca = 6;
        int numeroProximo = ObterNumeroMaisProximo(numerosOrdenados, valorDeBusca);

        Console.WriteLine($"O número mais próximo de {valorDeBusca} é: {numeroProximo}");
    }
}