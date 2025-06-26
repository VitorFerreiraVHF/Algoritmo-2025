using System;
using System.Collections.Generic;
using System.Linq;


public interface IPagamento
{
    void ProcessarPagamento(decimal valor);
}

public class PagamentoCartaoCredito : IPagamento
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Pagamento de R${valor} processado no cartão de crédito.");
    }
}

public class PagamentoBoleto : IPagamento
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Pagamento de R${valor} processado via boleto bancário.");
    }
}

public class PagamentoPIX : IPagamento
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Pagamento de R${valor} processado via PIX.");
    }
}

public class LojaVirtual
{
    public void RealizarPagamento(IPagamento metodo, decimal valor)
    {
        metodo.ProcessarPagamento(valor);
    }
}

public class Program
{
    public static void Main()
    {
        LojaVirtual loja = new LojaVirtual();

        Console.WriteLine("Sistema de Pagamentos da Loja Virtual");
        Console.WriteLine();

        Console.Write("Digite o valor do pagamento: R$");
        decimal valor;
        while (!decimal.TryParse(Console.ReadLine(), out valor) || valor <= 0)
        {3
            Console.Write("Valor inválido. Digite novamente: R$");
        }

        Console.WriteLine("\nSelecione o método de pagamento:");
        Console.WriteLine("1 - Cartão de Crédito");
        Console.WriteLine("2 - Boleto Bancário");
        Console.WriteLine("3 - PIX");
        Console.Write("Opção: ");

        int opcao;
        while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 3)
        {
            Console.Write("Opção inválida. Digite novamente (1-3): ");
        }

        IPagamento metodoPagamento = null;

        switch (opcao)
        {
            case 1:
                metodoPagamento = new PagamentoCartaoCredito();
                break;
            case 2:
                metodoPagamento = new PagamentoBoleto();
                break;
            case 3:
                metodoPagamento = new PagamentoPIX();
                break;
        }

        Console.WriteLine("\nProcessando pagamento...");
        loja.RealizarPagamento(metodoPagamento, valor);

        Console.WriteLine("\nPagamento concluído com sucesso!");
    }
}