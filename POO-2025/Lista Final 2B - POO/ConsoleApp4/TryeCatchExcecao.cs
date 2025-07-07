using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        bool continuar = true;

        Console.WriteLine("Divisão de Inteiros");
        Console.WriteLine("Digite 'sair' a qualquer momento para encerrar.");

        while (continuar)
        {
            try
            {
                Console.Write("\nDigite o primeiro número (ou 'sair'): ");
                string input1 = Console.ReadLine();

                if (input1.ToLower() == "sair")
                {
                    continuar = false;
                    break;
                }

                int numero1 = int.Parse(input1);

                Console.Write("Digite o segundo número (ou 'sair'): ");
                string input2 = Console.ReadLine();

                if (input2.ToLower() == "sair")
                {
                    continuar = false;
                    break;
                }

                int numero2 = int.Parse(input2);

                int resultado = numero1 / numero2;
                Console.WriteLine($"Resultado: {numero1} / {numero2} = {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Valor inválido. Digite um número inteiro válido.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro: Não é possível dividir por zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
            }
        }

        Console.WriteLine("\nPrograma encerrado");
    }
}