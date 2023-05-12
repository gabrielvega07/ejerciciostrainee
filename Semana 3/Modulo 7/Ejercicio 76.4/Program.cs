// See https://aka.ms/new-console-template for more information

List<int> numeros = new List<int>();

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Ingresar el numero {i}:");
    int numero = int.Parse( Console.ReadLine() );
    numeros.Add( numero );  
}

int maximo = numeros[0];
int minimo = numeros[0];

for (int i = 1; i < numeros.Count; i++)
{
    if(numeros[i] > maximo)
    {
        maximo = numeros[i];
    }

    if (numeros[i] < minimo) 
    { 
        minimo = numeros[i]; 
    }
}

Console.WriteLine($"El numero maximo es {maximo}.");
Console.WriteLine($"El numero minimo es {minimo}.");

Console.ReadLine();


