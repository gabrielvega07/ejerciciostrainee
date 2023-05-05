// See https://aka.ms/new-console-template for more information

Console.Write("Introduzca un número: ");
int numero = int.Parse(Console.ReadLine());

ImprimirTabla(numero);


static void ImprimirTabla(int numero)
{
    Console.WriteLine($"Labla de multiplicar del {numero} es:");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    }
}

Console.ReadKey();
