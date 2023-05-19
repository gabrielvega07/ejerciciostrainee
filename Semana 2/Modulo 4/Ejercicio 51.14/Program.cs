// See https://aka.ms/new-console-template for more information

Console.Write("Ingresa un numero: ");
int numero = int.Parse(Console.ReadLine());

int cifras = 0;
while (numero != 0)
{
    numero /= 10;
    cifras++;
}

Console.WriteLine($"El numero tiene {cifras} cifras.");

Console.ReadKey();