internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(" Ingrese un numero: ");
        int x = int.Parse(Console.ReadLine());
        int i = 1;

        while (i <= 10)
        {
            Console.WriteLine(x + " x " + i + " = " + x * i);
            i++;
        }
    }
}

