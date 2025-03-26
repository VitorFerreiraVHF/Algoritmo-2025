using Ativ1;

public class Program
{
    public static void Main()
    {
        Aluno _aluno = new Aluno();

        Console.WriteLine("Insira o RA:");
        _aluno.Ra = Console.ReadLine();

        Console.WriteLine("Insira o nome:");
        _aluno.Nome = Console.ReadLine();

        Console.WriteLine("Nota da Prova P1:");
        _aluno.NotaProva1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Nota do Trabalho T1:");
        _aluno.NotaTrabalho1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Nota da Prova P2:");
        _aluno.NotaProva2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Nota do Trabalho T2:");
        _aluno.NotaTrabalho2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Nota do ACQG:");
        _aluno.ACQG = double.Parse(Console.ReadLine());

        _aluno.CalcularMedia();
        _aluno.CalcularNotaFinal();
        _aluno.ExibirResultado();
    }
}