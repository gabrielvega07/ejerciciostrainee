// See https://aka.ms/new-console-template for more information

Console.Write("Ingresa un número: ");
int numero = int.Parse(Console.ReadLine());

bool esPrimo = true;
for (int i = 2; i <= Math.Sqrt(numero); i++)
{
    if (numero % i == 0)
    {
        esPrimo = false;
        break;
    }
}

if (esPrimo)
{
    Console.WriteLine($"{numero} si es primo.");
}
else
{
    Console.WriteLine($"{numero} no es primo.");
}

Console.ReadKey();