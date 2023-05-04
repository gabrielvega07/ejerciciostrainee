// See https://aka.ms/new-console-template for more information


Console.WriteLine("Ingrese el nombre de un dia de la semana: ");
string dia = Console.ReadLine();    

switch (dia.ToLower())
{
    case "lunes":
    case "martes":
    case "miércoles":
    case "jueves":
    case "viernes":
        Console.WriteLine("No es fin de semana, volver al trabajo"); 
        break;

    case "sabado":
    case "domingo":
        Console.WriteLine("Es fin de semana, puedes descansar ");
        break;
    default:
        Console.WriteLine("El dia ingresado no es valido");
        break;
}

Console.ReadKey();