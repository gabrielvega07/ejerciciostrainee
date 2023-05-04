// See https://aka.ms/new-console-template for more information

int numero;
do
{
    Console.Write("Ingresa un numero del 1 a 1000: ");
    numero = int.Parse(Console.ReadLine());
} while (numero < 1 || numero > 1000);

int suma = 0;
for (int i = 1; i <= numero; i++)
{
    suma += i;
}

double media = (double)suma / numero;

Console.WriteLine($"La suma del 1 al {numero} es {suma}");
Console.WriteLine($"La media del 1 al {numero} es {media}");

Console.ReadKey();