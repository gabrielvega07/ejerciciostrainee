// See https://aka.ms/new-console-template for more information

int numero1, numero2;

Console.WriteLine("Ingrese un numero: ");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese un numero: ");
numero2 = Convert.ToInt32(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine("El numero mayor es: " + numero1);
}
else
{
    Console.WriteLine("El numero mayor es: " + numero2);
}

Console.ReadKey();
