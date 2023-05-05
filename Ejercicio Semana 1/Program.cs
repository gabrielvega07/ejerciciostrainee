// See https://aka.ms/new-console-template for more information



int numero = 0;
bool primo = true;

Console.WriteLine("Ingrese un numero: ");
numero = int.Parse(Console.ReadLine());

if (numero > 100)
{
    Console.WriteLine("El numero es mayor a 100.");

}
else if (numero < 100)
{
    Console.WriteLine("El numero es menor a 100.");

}
else
{
    Console.WriteLine("El numero es 100");
}

if (numero % 2 == 0)
{
    Console.WriteLine("El nuemro es par");
}
else
{
    Console.WriteLine("El numero es impar");

}

if (numero  <= 2)
{
    primo = true;
    
}
else
{
    for (int i = 2; i <= Math.Sqrt(numero); i++)
    {
        if (numero % i == 0)
        {
            primo = false;
            break;
        }
    }
}

if (primo)
{
    Console.WriteLine("El numero es primo");
}
else
{
    Console.WriteLine("El numero no es primo");
}

Console.ReadLine();