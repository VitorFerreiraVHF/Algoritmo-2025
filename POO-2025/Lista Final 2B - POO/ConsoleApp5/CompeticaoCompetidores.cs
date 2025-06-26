using System;
using System.Collections.Generic;
using System.Linq;

namespace CompeticaoApp
{
    public class Competidor
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Modalidade { get; set; }

        public Competidor(string nome, int idade, string modalidade)
        {
            Nome = nome;
            Idade = idade;
            Modalidade = modalidade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Modalidade: {Modalidade}";
        }
    }

    public class Competicao
    {
        public string Nome { get; private set; }
        private List<Competidor> Competidores { get; set; }

        public Competicao(string nome)
        {
            Nome = nome;
            Competidores = new List<Competidor>();
        }

        public void AdicionarCompetidor(Competidor competidor)
        {
            Competidores.Add(competidor);
        }

        public bool RemoverCompetidor(string nome)
        {
            var competidor = Competidores.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (competidor != null)
            {
                Competidores.Remove(competidor);
                return true;
            }
            return false;
        }

        public bool EditarCompetidor(string nome, string novoNome, int novaIdade, string novaModalidade)
        {
            var competidor = Competidores.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (competidor != null)
            {
                competidor.Nome = novoNome;
                competidor.Idade = novaIdade;
                competidor.Modalidade = novaModalidade;
                return true;
            }
            return false;
        }

        public void ListarCompetidores()
        {
            if (Competidores.Count == 0)
            {
                Console.WriteLine("Nenhum competidor cadastrado nesta competição.");
                return;
            }

            Console.WriteLine($"\nCompetidores da competição {Nome}:");
            for (int i = 0; i < Competidores.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Competidores[i]}");
            }
        }

        public Competidor GetCompetidorPorNome(string nome)
        {
            return Competidores.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }
    }

    class Program
    {
        static Competicao competicaoAtual = null;

        static void Main(string[] args)
        {
            bool sair = false;

            while (!sair)
            {
                ExibirMenu();
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarCompeticao();
                        break;
                    case "2":
                        AdicionarCompetidor();
                        break;
                    case "3":
                        ListarCompetidores();
                        break;
                    case "4":
                        EditarCompetidor();
                        break;
                    case "5":
                        RemoverCompetidor();
                        break;
                    case "6":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void ExibirMenu()
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("1. Cadastrar uma nova competição");
            Console.WriteLine("2. Adicionar competidores à competição");
            Console.WriteLine("3. Listar os competidores cadastrados");
            Console.WriteLine("4. Editar um competidor");
            Console.WriteLine("5. Remover um competidor");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");
        }

        static void CadastrarCompeticao()
        {
            Console.Write("\nDigite o nome da competição: ");
            string nome = Console.ReadLine();
            competicaoAtual = new Competicao(nome);
            Console.WriteLine($"Competição '{nome}' cadastrada com sucesso!");
        }

        static void AdicionarCompetidor()
        {
            if (competicaoAtual == null)
            {
                Console.WriteLine("Nenhuma competição cadastrada. Crie uma competição primeiro.");
                return;
            }

            Console.Write("\nDigite o nome do competidor: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade do competidor: ");
            int idade;
            while (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
            {
                Console.Write("Idade inválida. Digite novamente: ");
            }

            Console.Write("Digite a modalidade do competidor: ");
            string modalidade = Console.ReadLine();

            Competidor novoCompetidor = new Competidor(nome, idade, modalidade);
            competicaoAtual.AdicionarCompetidor(novoCompetidor);
            Console.WriteLine("Competidor adicionado com sucesso!");
        }

        static void ListarCompetidores()
        {
            if (competicaoAtual == null)
            {
                Console.WriteLine("Nenhuma competição cadastrada. Crie uma competição primeiro.");
                return;
            }

            competicaoAtual.ListarCompetidores();
        }

        static void EditarCompetidor()
        {
            if (competicaoAtual == null)
            {
                Console.WriteLine("Nenhuma competição cadastrada. Crie uma competição primeiro.");
                return;
            }

            competicaoAtual.ListarCompetidores();
            if (competicaoAtual.GetCompetidorPorNome("") == null) return;

            Console.Write("\nDigite o nome do competidor que deseja editar: ");
            string nomeAntigo = Console.ReadLine();

            var competidor = competicaoAtual.GetCompetidorPorNome(nomeAntigo);
            if (competidor == null)
            {
                Console.WriteLine("Competidor não encontrado.");
                return;
            }

            Console.Write("Digite o novo nome do competidor (atual: {0}): ", competidor.Nome);
            string novoNome = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(novoNome)) novoNome = competidor.Nome;

            Console.Write("Digite a nova idade do competidor (atual: {0}): ", competidor.Idade);
            string idadeInput = Console.ReadLine();
            int novaIdade;
            if (!int.TryParse(idadeInput, out novaIdade) || novaIdade <= 0) novaIdade = competidor.Idade;

            Console.Write("Digite a nova modalidade do competidor (atual: {0}): ", competidor.Modalidade);
            string novaModalidade = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(novaModalidade)) novaModalidade = competidor.Modalidade;

            bool sucesso = competicaoAtual.EditarCompetidor(nomeAntigo, novoNome, novaIdade, novaModalidade);
            if (sucesso)
            {
                Console.WriteLine("Competidor editado com sucesso!");
            }
            else
            {
                Console.WriteLine("Falha ao editar competidor.");
            }
        }

        static void RemoverCompetidor()
        {
            if (competicaoAtual == null)
            {
                Console.WriteLine("Nenhuma competição cadastrada. Crie uma competição primeiro.");
                return;
            }

            competicaoAtual.ListarCompetidores();
            if (competicaoAtual.GetCompetidorPorNome("") == null) 
                return;

            Console.Write("\nDigite o nome do competidor que deseja remover: ");
            string nome = Console.ReadLine();

            bool sucesso = competicaoAtual.RemoverCompetidor(nome);
            if (sucesso)
            {
                Console.WriteLine("Competidor removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Competidor não encontrado.");
            }
        }
    }
}