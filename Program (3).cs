internal class Program
{
    private static void Main(string[] args)
    {
        // Exercício 2.2

        double[] valores = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double a = valores[0], b = valores[1], c = valores[2];
        double delta = Math.Pow(b, 2) - 4 * (a * c);

        if (a == 0 || delta < 0)
        {
            Console.WriteLine("Impossível calcular");
        }
        else
        {
            Console.WriteLine($"X1 = {(-b + Math.Sqrt(delta)) / (2 * a)}");
            Console.WriteLine($"X2 = {(-b - Math.Sqrt(delta)) / (2 * a)}");
        }
    }
}