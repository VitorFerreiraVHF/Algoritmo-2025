using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativ1
{
    internal class Aluno
    {
        public string Ra { get; set; }
        public string Nome { get; set; }
        public double NotaProva1 { get; set; }
        public double NotaTrabalho1 { get; set; }
        public double NotaProva2 { get; set; }
        public double NotaTrabalho2 { get; set; }
        public double ACQG { get; set; }
        public double Media { get; private set; }
        public double NotaFim { get; private set; }

        public void CalcularMedia()
        {
            Media = (NotaProva1 + NotaTrabalho1) / 2.0;
            Console.WriteLine($"A média da nota do aluno é {Media}");
        }

        public void CalcularNotaFinal()
        {
            NotaFim = (NotaProva2 + NotaTrabalho2) / 2.0 + ACQG;
            Console.WriteLine($"A nota final é: {NotaFim}");
        }

        public void ExibirResultado()
        {
            if (NotaFim >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}