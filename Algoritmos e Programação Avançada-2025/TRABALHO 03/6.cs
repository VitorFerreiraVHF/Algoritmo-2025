using System;

public class JogoDaVelha
{
    static char[,] tabuleiro = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
    static int jogadorAtual = 1;

    public static void Main(string[] args)
    {
        bool jogoAcabou = false;
        int jogadas = 0;

        while (!jogoAcabou)
        {
            DesenharTabuleiro();
            FazerJogada();
            jogoAcabou = VerificarVencedor();
            if (!jogoAcabou)
            {
                jogoAcabou = jogadas == 8;
            }
            jogadorAtual = jogadorAtual == 1 ? 2 : 1;
            jogadas++;
        }

        DesenharTabuleiro();
        if (VerificarVencedor())
        {
            Console.WriteLine($"Jogador {jogadorAtual} venceu!");
        }
        else
        {
            Console.WriteLine("Empate!");
        }
    }

    static void DesenharTabuleiro()
    {
        Console.Clear();
        Console.WriteLine("  0 1 2");
        Console.WriteLine("0 " + tabuleiro[0, 0] + "|" + tabuleiro[0, 1] + "|" + tabuleiro[0, 2]);
        Console.WriteLine("  -+-+-");
        Console.WriteLine("1 " + tabuleiro[1, 0] + "|" + tabuleiro[1, 1] + "|" + tabuleiro[1, 2]);
        Console.WriteLine("  -+-+-");
        Console.WriteLine("2 " + tabuleiro[2, 0] + "|" + tabuleiro[2, 1] + "|" + tabuleiro[2, 2]);
    }

    static void FazerJogada()
    {
        int linha, coluna;
        bool jogadaValida = false;

        while (!jogadaValida)
        {
            Console.Write($"Jogador {jogadorAtual}, digite a linha (0-2): ");
            linha = int.Parse(Console.ReadLine());

            Console.Write($"Jogador {jogadorAtual}, digite a coluna (0-2): ");
            coluna = int.Parse(Console.ReadLine());

            if (linha >= 0 && linha < 3 && coluna >= 0 && coluna < 3 && tabuleiro[linha, coluna] == ' ')
            {
                tabuleiro[linha, coluna] = jogadorAtual == 1 ? 'X' : 'O';
                jogadaValida = true;
            }
            else
            {
                Console.WriteLine("Jogada inválida. Tente novamente.");
            }
        }
    }

    static bool VerificarVencedor()
    {
        for (int i = 0; i < 3; i++)
        {
            if (tabuleiro[i, 0] != ' ' && tabuleiro[i, 0] == tabuleiro[i, 1] && tabuleiro[i, 1] == tabuleiro[i, 2])
            {
                return true;
            }
        }

        for (int i = 0; i < 3; i++)
        {
            if (tabuleiro[0, i] != ' ' && tabuleiro[0, i] == tabuleiro[1, i] && tabuleiro[1, i] == tabuleiro[2, i])
            {
                return true;
            }
        }

        if (tabuleiro[0, 0] != ' ' && tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2])
        {
            return true;
        }

        if (tabuleiro[0, 2] != ' ' && tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0])
        {
            return true;
        }

        return false;
    }
}