using System;

class Programa
{
    static bool VerificarPalavraNoDicionario(string[] listaDePalavras, string palavraProcurada)
    {
        int indiceInicial = 0;
        int indiceFinal = listaDePalavras.Length - 1;

        while (indiceInicial <= indiceFinal)
        {
            int indiceMediano = (indiceInicial + indiceFinal) / 2;

            if (listaDePalavras[indiceMediano] == palavraProcurada)
            {
                return true;
            }
            else if (listaDePalavras[indiceMediano].CompareTo(palavraProcurada) < 0)
            {
                indiceInicial = indiceMediano + 1;
            }
            else
            {
                indiceFinal = indiceMediano - 1;
            }
        }

        return false;
    }

    static void Main()
    {
        string[] palavrasDoDicionario = { "abacaxi", "bola", "carro", "elefante", "foca", "gato", "hipopotamo", "iguana", "jacare", "kiwi" };
        string palavraParaBuscar = "foca";

        bool resultadoBusca = VerificarPalavraNoDicionario(palavrasDoDicionario, palavraParaBuscar);

        Console.WriteLine(resultadoBusca ? "Palavra encontrada" : "Palavra não encontrada");
    }
}