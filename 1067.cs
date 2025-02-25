using System;

public class ExercicioImpares
{
    public static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        if (x >= 1 && x <= 1000)
        {
            Console.WriteLine("Seus numeros impares sao:");
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("O valor deve estar entre 1 e 1000.");
        }
    }
}
