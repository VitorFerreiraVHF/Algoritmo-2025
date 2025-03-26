using Exer4;
internal class Program
{
    private static void Main(string[] args)
    {
        Lampada lampada = new Lampada();
        lampada.Ligar();
        lampada.Desligar();
        lampada.MostrarEstado();


        Console.ReadLine();
    }
}
/*
Criar a classe Lampada com os seguintes atributos:


Ligada (bool) → Indica se a lâmpada está ligada ou desligada.
Criar os seguintes métodos sem retorno e sem parâmetros:


Ligar(): Liga a lâmpada.
Desligar(): Desliga a lâmpada.
MostrarEstado(): Exibe se a lâmpada está ligada ou desligada.
*/