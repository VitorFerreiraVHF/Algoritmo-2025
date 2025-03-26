using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer4
{
    internal class Lampada
    {
        public bool Ligada { get; private set; }
        public void Ligar()
        {
            Ligada = true;
            Console.Write("Ligada");
        }
        public void Desligar()
        {
            Ligada = true;
            Console.Write("Desligada");
        }
        public void MostrarEstado()
        {
            if (Ligada)
                Console.WriteLine("Ligada.");
            else
                Console.WriteLine("Desligada.");
        }


    }
}
