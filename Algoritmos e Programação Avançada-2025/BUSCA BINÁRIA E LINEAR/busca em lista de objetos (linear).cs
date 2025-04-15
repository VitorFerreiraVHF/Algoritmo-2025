using System;

class Estudante
{
    public string NomeCompleto { get; set; }
    public int NumeroRegistro { get; set; }

    public Estudante(string nome, int registro)
    {
        NomeCompleto = nome;
        NumeroRegistro = registro;
    }
}

class Programa
{
    static Estudante ObterEstudantePorRegistro(Estudante[] listaEstudantes, int registroProcurado)
    {
        for (int i = 0; i < listaEstudantes.Length; i++)
        {
            if (listaEstudantes[i].NumeroRegistro == registroProcurado)
            {
                return listaEstudantes[i];
            }
        }
        return null;
    }

    static void Main()
    {
        Estudante[] registrosDeEstudantes = {
            new Estudante("Ana", 1001),
            new Estudante("Carlos", 1002),
            new Estudante("Maria", 1003),
            new Estudante("João", 1004)
        };

        int registroDeBusca = 1003;
        Estudante estudanteLocalizado = ObterEstudantePorRegistro(registrosDeEstudantes, registroDeBusca);

        if (estudanteLocalizado != null)
        {
            Console.WriteLine($"Aluno encontrado: {estudanteLocalizado.NomeCompleto}");
        }
        else
        {
            Console.WriteLine("Aluno não encontrado.");
        }
    }
}