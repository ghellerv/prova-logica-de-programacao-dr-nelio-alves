﻿internal class Program
{
    private static void Main(string[] args)
    {
        // Exercício 1.1 

        Console.Clear();
        Console.WriteLine("Input1: ");
        double[] primeiro = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        Console.WriteLine("Input2: ");
        double[] segundo = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        double valorPagar = (primeiro[1] * primeiro[2]) + (segundo[1] * segundo[2]);

        Console.WriteLine($"VALOR A PAGAR: R$ {valorPagar.ToString("N2")}");


    }
}