
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un numero para el Ancho: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese un numero para el Alto: ");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("¿Esta Relleno? (S/N): ");
char r = Console.ReadKey().KeyChar;
bool R = r == 'S' || r == 's' ? true : false;

Console.WriteLine();
Console.WriteLine("Ingrese el numero de Repeticiones: ");
int n = int.Parse(Console.ReadLine());

char[,] arr = new char[x, y];


if (R)
{
    //Esta relleno
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            arr[i, j] = '*';
        }
    }
}
else
{
    //No esta relleno
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            arr[i, j] = i == 0 || j == 0 || i == x - 1 || j == y - 1 ? '*' : ' ';
        }
    }
}

if (x == 2 && y == 2)
{


    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine();
        for (int z = 0; z < n; z++)
        {
            Console.Write("  ");
            for (int j = 0; j < 2; j++)
            {
                Console.Write("*");
            }
        }
    }

}
else
{
    for (int j = 0; j < y; j++)
    {
        Console.WriteLine();
        for (int z = 0; z < n; z++)
        {
            Console.Write("  ");
            for (int i = 0; i < x; i++)
            {
                Console.Write(arr[i, j]);
            }
        }
    }

}