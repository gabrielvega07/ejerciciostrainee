// See https://aka.ms/new-console-template for more information

double dolares, euros; 

Console.WriteLine("Tipo de cabmio a realizar: ");
Console.WriteLine("1. Convertir de dólares a euros");
Console.WriteLine("2. Convertir de euros a dólares");

int opcion = int.Parse(Console.ReadLine());

double tipoCambio = PedirTipoCambio();

switch (opcion)
{
    case 1:
        dolares = PedirCantidad("dólares");
        euros = ConvertirDolaresAEuros(dolares, tipoCambio);
        Console.WriteLine($"{dolares} dólares equivalen a {euros} euros");
        break;

    case 2:
         euros = PedirCantidad("euros");
         dolares = ConvertirEurosADolares(euros, tipoCambio);
        Console.WriteLine($"{euros} euros equivalen a {dolares} dólares");
        break;

    default:
        Console.WriteLine("Opción no válida");
        break;
}

Console.ReadKey();

//Funciones 
static double PedirCantidad(string cantidad)
{
    Console.WriteLine($"Introduzca la cantidad de {cantidad} a convertir:");
    return double.Parse(Console.ReadLine());
}

static double PedirTipoCambio()
{
    Console.WriteLine("Introduzca el tipo de cambio actual:");
    return double.Parse(Console.ReadLine());
}

static double ConvertirDolaresAEuros(double dolares, double tipoCambio)
{
    return dolares * tipoCambio;
}

static double ConvertirEurosADolares(double euros, double tipoCambio)
{
    return euros * tipoCambio;
}