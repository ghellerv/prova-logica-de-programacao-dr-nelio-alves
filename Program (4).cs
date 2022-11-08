internal class Program
{
    private static void Main(string[] args)
    {
        // Exercício 2.1

        double[] valores = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double total = 0;

        switch (valores[0])
        {
            case 1: total = 4 * valores[1]; break;
            case 2: total = 4.50 * valores[1]; break;
            case 3: total = 5 * valores[1]; break;
            case 4: total = 2 * valores[1]; break;
            case 5: total = 1.50 * valores[1]; break;
        }

        Console.WriteLine($"Total: R$ {total.ToString("N2")}");

    }
}