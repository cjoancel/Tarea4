
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un numero: ");
int x = int.Parse(Console.ReadLine());

if (x == 0) { Console.WriteLine("El valor ingresado es 0"); }
else
{
    int i = 0;

    if (x > 0)
    {
        Console.WriteLine("El valor es Positivo");
        do
        {
            Console.Write(" " + i);
            i++;
        } while (i < x);
    }
    else
    {
        Console.WriteLine("El valor es Negativo");
        do
        {
            Console.Write(" " + i);
            i--;
        } while (i > x);
    }
}
