// See https://aka.ms/new-console-template for more information

int[] numerosPares = new int[50]; 
int posicion = 0; 

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        numerosPares[posicion] = i;
        posicion++;
    }
}
foreach (int num in numerosPares)
{
    Console.WriteLine(num);
}

Console.ReadKey();