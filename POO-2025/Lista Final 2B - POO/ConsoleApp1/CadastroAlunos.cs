using System;
using System.Collections.Generic;
using System.Linq;

class Aluno
{
    public string RA { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Aluno(string ra, string nome, int idade)
    {
        RA = ra;
        Nome = nome;
        Idade = idade;
    }

    public override string ToString()
    {
        return $"RA: {RA}, Nome: {Nome}, Idade: {Idade}";
    }
}

class CadastroDeAlunos
{
    static List<Aluno> alunos = new List<Aluno>();

    static void Main(string[] args)
    {
        bool executando = true;

        while (executando)
        {
            ExibirMenu();
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarAluno();
                    break;
                case "2":
                    ListarAlunos();
                    break;
                case "3":
                    AlterarAluno();
                    break;
                case "4":
                    RemoverAluno();
                    break;
                case "5":
                    executando = false;
                    Console.WriteLine("Encerar...");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void ExibirMenu()
    {
        Console.Clear();
        Console.WriteLine("1. Cadastrar aluno");
        Console.WriteLine("2. Listar todos os alunos");
        Console.WriteLine("3. Alterar dados de um aluno");
        Console.WriteLine("4. Remover aluno");
        Console.WriteLine("5. Sair");
        Console.Write("Escolha uma opção: ");
    }

    static void CadastrarAluno()
    {
        Console.Clear();
        Console.WriteLine("CADASTRO ALUNO");

        Console.Write("Digite o RA: ");
        string ra = Console.ReadLine();

        // Verifica se o RA já existe
        if (alunos.Any(a => a.RA == ra))
        {
            Console.WriteLine($"Já existe um aluno cadastrado com esse RA {ra}.");
            return;
        }

        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a idade: ");
        if (!int.TryParse(Console.ReadLine(), out int idade))
        {
            Console.WriteLine("Idade inválida. Cadastro cancelado.");
            return;
        }

        alunos.Add(new Aluno(ra, nome, idade));
        Console.WriteLine("Aluno cadastrado!");
    }

    static void ListarAlunos()
    {
        Console.Clear();
        Console.WriteLine("LISTA DE ALUNOS");

        if (alunos.Count == 0)
        {
            Console.WriteLine("Nenhum aluno cadastrado.");
            return;
        }

        foreach (var aluno in alunos)
        {
            Console.WriteLine(aluno);
        }

        Console.WriteLine($"\nTotal de alunos: {alunos.Count}");
    }

    static void AlterarAluno()
    {
        Console.Clear();
        Console.WriteLine("ALTERAR DADOS DO ALUNO");

        Console.Write("Digite o RA de quem deseja alterar: ");
        string ra = Console.ReadLine();

        Aluno aluno = alunos.FirstOrDefault(a => a.RA == ra);

        if (aluno == null)
        {
            Console.WriteLine($"Aluno com RA {ra} não encontrado.");
            return;
        }

        Console.WriteLine($"Aluno encontrado: {aluno}");

        Console.Write("Digite o novo nome: ");
        string novoNome = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(novoNome))
        {
            aluno.Nome = novoNome;
        }

        Console.Write("Digite a nova idade: ");
        string novaIdadeStr = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(novaIdadeStr))
        {
            if (int.TryParse(novaIdadeStr, out int novaIdade))
            {
                aluno.Idade = novaIdade;
            }
            else
            {
                Console.WriteLine("Idade inválida. Alteração não realizada.");
            }
        }

        Console.WriteLine("Dados do aluno atualizados com sucesso!");
    }

    static void RemoverAluno()
    {
        Console.Clear();
        Console.WriteLine("REMOVER ALUNO");

        Console.Write("Digite o RA do aluno que deseja remover: ");
        string ra = Console.ReadLine();

        Aluno aluno = alunos.FirstOrDefault(a => a.RA == ra);

        if (aluno == null)
        {
            Console.WriteLine($"Aluno com RA {ra} não encontrado.");
            return;
        }

        Console.WriteLine($"Aluno encontrado: {aluno}");
        Console.Write("Tem certeza que deseja remover este aluno? (Sim/Nao): ");
        string confirmacao = Console.ReadLine().ToUpper();

        if (confirmacao == "S")
        {
            alunos.Remove(aluno);
            Console.WriteLine("Aluno removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Operação cancelada.");
        }
    }
}