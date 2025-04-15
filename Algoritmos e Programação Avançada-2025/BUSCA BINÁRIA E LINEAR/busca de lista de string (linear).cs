using System;

class Program
{
    static int ObterIndiceDeNome(string[] listaDeNomes, string nomeParaBuscar)
    {
        for (int i = 0; i < listaDeNomes.Length; i++)
        {
            if (listaDeNomes[i] == nomeParaBuscar)
            {
                return i;
            }
        }
        return -1;
    }

    static void Main()
    {
        string[] nomesDeParticipantes = { "Ana", "Carlos", "Maria", "João", "Pedro" };
        string nomeAlvo = "Maria";
        int indiceEncontrado = ObterIndiceDeNome(nomesDeParticipantes, nomeAlvo);

        if (indiceEncontrado != -1)
        {
            Console.WriteLine($"O nome {nomeAlvo} está no índice {indiceEncontrado}");
        }
        else
        {
            Console.WriteLine("Nome não encontrado");
        }
    }
}