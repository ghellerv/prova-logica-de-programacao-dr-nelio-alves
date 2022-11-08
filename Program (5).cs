internal class Program
{
    private static void Main(string[] args)
    {
        // Exercicio 1.2 

        double pi = 3.14159;
        double raio = double.Parse(Console.ReadLine());
        double area = pi * (Math.Pow(raio, 2));

        Console.WriteLine(area.ToString("N4"));

    }
}