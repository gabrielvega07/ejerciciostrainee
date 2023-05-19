// See https://aka.ms/new-console-template for more information

Console.WriteLine("Seleccione una operacion: ");
Console.WriteLine("1. Suma");
Console.WriteLine("2. Resta");
Console.WriteLine("3. Multiplicación");
Console.WriteLine("4. División");


int opcion = int.Parse(Console.ReadLine());

double numero1 = PedirNumero("primer");
double numero2 = PedirNumero("segundo");


switch (opcion)
{
    case 1:
        double resultado1 = Sumar(numero1, numero2);
        Console.WriteLine($"La suma de {numero1} más {numero2} es: {resultado1}");
        break;

    case 2:
        double resultado2 = Restar(numero1, numero2);
        Console.WriteLine($"La resta de {numero1} menos {numero2} es: {resultado2}");
        break;

    case 3:
        double resultado3 = Multiplicar(numero1, numero2);
        Console.WriteLine($"La multiplicación de {numero1} por {numero2} es: {resultado3}");
        break;

    case 4:
        if (numero2 == 0)
        {
            Console.WriteLine("No se puede dividir por cero");
        }
        else
        {
            double resultado4 = Dividir(numero1, numero2);
            Console.WriteLine($"La división de {numero1} entre {numero2} es: {resultado4}");
        }
        break;

    default:
        Console.WriteLine("Opción no válida");
        break;
}

Console.ReadKey();

//funciones

static double PedirNumero(string posicion)
{
    Console.WriteLine($"Introduzca el {posicion} número:");
    return double.Parse(Console.ReadLine());
}

static double Sumar(double num1, double num2)
{
    return num1 + num2;
}

static double Restar(double num1, double num2)
{
    return num1 - num2;
}

static double Multiplicar(double num1, double num2)
{
    return num1 * num2;
}

static double Dividir(double num1, double num2)
{
    return num1 / num2;
}