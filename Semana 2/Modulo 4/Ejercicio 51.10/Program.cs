// See https://aka.ms/new-console-template for more information

int sumaPares = 0;
int restaImpares = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write("Ingresa un número: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        sumaPares += numero; //se usa el operador += para sumar un valor a una variable existente 
    }
    else
    {
        restaImpares -= numero; //es usa el operador -= para restar un valor a una variable existente 
    }
}

int resultado = sumaPares + restaImpares;

Console.WriteLine($"El resultado es: {resultado}");
Console.ReadKey();