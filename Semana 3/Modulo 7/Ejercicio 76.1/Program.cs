// See https://aka.ms/new-console-template for more information

List<int> numeros = new List<int>();

// Recorrer del 1 a 1000 y agregarlos a la lista 
for (int i = 1; i <= 1000; i++)
{
    numeros.Add(i);

    //Calculamos la suma de los números en la lista hasta la iteración actual
    int suma = 0;
    for (int j = 0; j < numeros.Count; j++)
    {
        suma += numeros[j];
    }
    Console.WriteLine(suma);
}

    Console.ReadKey();

