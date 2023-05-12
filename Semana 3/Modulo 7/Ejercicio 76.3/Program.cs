// See https://aka.ms/new-console-template for more information

List<int> numeros = new List<int>();

int sumarPares = 0;
int sumarImpares = 0;

for  (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Introduce el numero {i}: ");
    int numero = int.Parse( Console.ReadLine() );
    numeros.Add(numero);
}

for (int i = 0; i < numeros.Count; i++)
{
    if (numeros[i] % 2 == 0)
    {
        sumarPares += numeros[i];
    }

    else
    {
        sumarImpares += numeros[i];
    }
}

Console.WriteLine($"La suma de los pares es {sumarPares}");
Console.WriteLine($"La suma de los impares es {sumarImpares}");

Console.ReadLine();



