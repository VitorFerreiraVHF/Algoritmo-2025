using Exer2;
public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite qual operação você deseja realizar \n 1 - Depositar \n 2 - Sacar \n 3 - Exibir o Saldo");
        int operacaoBancaria = Convert.ToInt32(Console.ReadLine());

            ContaBancaria conta = new ContaBancaria();
        if (operacaoBancaria == 1)
        {
            Console.WriteLine("Digite o valor que você deseja depositar: ");
            int Deposito = Convert.ToInt32(Console.ReadLine());

            conta.Deposito = Deposito;         
        }
        else if (operacaoBancaria == 2)
        {
            Console.WriteLine("Digite o valor que você deseja Sacar: ");
            int Saque = Convert.ToInt32(Console.ReadLine());

            conta.Saque = Saque;
        }
        else if (operacaoBancaria == 3)
        {
            Console.Write($"O seu saldo é de R${conta.Saldo}");

        }
        else
        {
            Console.WriteLine("OPERAÇÃO INVÁLIDA");
        }
    }
}

