// See https://aka.ms/new-console-template for more information

Console.Write("Ingresa un número del 1 al 7: ");
int dia = int.Parse(Console.ReadLine());

string diaSemana = "";

switch (dia)
{
    case 1:
        diaSemana = "Lunes";
        break;
    case 2:
        diaSemana = "Martes";
        break;
    case 3:
        diaSemana = "Miércoles";
        break;
    case 4:
        diaSemana = "Jueves";
        break;
    case 5:
        diaSemana = "Viernes";
        break;
    case 6:
        diaSemana = "Sábado";
        break;
    case 7:
        diaSemana = "Domingo";
        break;
    default:
        Console.WriteLine("El número ingresado no es válido para un dia de la semana.");
        break;
}

if (diaSemana != "")
{
    Console.WriteLine($"El día correspondiente al {dia} es {diaSemana}.");
}

Console.ReadKey();