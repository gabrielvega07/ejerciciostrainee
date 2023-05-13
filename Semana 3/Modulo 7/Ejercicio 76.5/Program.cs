// See https://aka.ms/new-console-template for more information

Console.WriteLine("Cuántos elementos tendrá el array? ");
int n = int.Parse(Console.ReadLine());

int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Introduce el valor para el elemento " + i + ": ");
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Introduce el nuevo valor ingresado: ");
int nuevoValor = int.Parse(Console.ReadLine());

Console.WriteLine("Posicion del nuevo valor ingresado: ");
int posicion = int.Parse(Console.ReadLine());

int[] nuevoArray = new int[n + 1];

for (int i = 0; i < posicion; i++)
{
    nuevoArray[i] = array[i];
}

nuevoArray[posicion] = nuevoValor;

for (int i = posicion + 1; i < n + 1; i++)
{
    nuevoArray[i] = array[i - 1];
}

Console.WriteLine("Array original: " + string.Join(", ", array));
Console.WriteLine("Nuevo array: " + string.Join(", ", nuevoArray));

Console.ReadKey();

