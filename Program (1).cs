internal class Program
{
    private static void Main(string[] args)
    {
        // Exercício 3.2

        Console.WriteLine("Número de inputs: ");
        int n = int.Parse(Console.ReadLine());
        int dentro = 0;
        int fora = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Digite o valor {i}: ");
            int temp = int.Parse(Console.ReadLine());
            if (temp >= 10 && temp <= 20)
            {
                dentro++;
            }
            else fora++;
        }

        Console.WriteLine(dentro + " in");
        Console.WriteLine(fora + " out");
    }
}