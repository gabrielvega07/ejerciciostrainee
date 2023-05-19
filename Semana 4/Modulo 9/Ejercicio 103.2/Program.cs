// See https://aka.ms/new-console-template for more information

using Ejercicio103._1;
using System.Xml.Linq;

clsPersona[] personas = new clsPersona[5];


static int PedirNumeroAlumno()
{
    Console.Write("Número de alumno: ");
    return int.Parse(Console.ReadLine());
}

static string PedirMateria()
{
    Console.Write("Materia que imparte: ");
    return Console.ReadLine();
}

Console.WriteLine("Ingrese los datos de la persona: ");

for  (int i = 0; i < personas.Length; i++)
{

    Console.WriteLine("Nombre: ");
    string nombre = Console.ReadLine();

    Console.WriteLine("La persona es alumno o profesor? ");
    string tipoPersona = Console.ReadLine();

    if (tipoPersona.ToLower() == "alumno")
    {
        personas[i] = new clsAlumno();
        ((clsAlumno)personas[i]).NumeroAlumno = PedirNumeroAlumno();
    }

    else if (tipoPersona.ToLower() == "profesor")
    {
        personas[i] = new clsProfesor();
        ((clsProfesor)personas[i]).MateriaImpartida = PedirMateria();
    }

    else
    {
        Console.WriteLine("El tipo de persona no corresponde a Alumno o Profesor.\n Se tomara como un apersona normal");
        personas[i] = new clsPersona();
    }

    personas[i].Nombre = nombre;


    Console.WriteLine("Edad: ");
    personas[i].Edad = int.Parse(Console.ReadLine());
}

Console.WriteLine("Las personas mayores de edad son: ");

foreach(clsPersona persona in personas)
{
    if (persona.Edad >= 18)
    {
        Console.WriteLine(persona.Nombre);
    }
}


Console.ReadKey();