﻿internal class Program
{
    private static void Main(string[] args)
    {
        // Exercício 3.1

        string senha = "2002";

        while (Console.ReadLine() != senha)
        {
            Console.WriteLine("Senha Invalida");
        }
        Console.WriteLine("Acesso Permitido");
    }
}