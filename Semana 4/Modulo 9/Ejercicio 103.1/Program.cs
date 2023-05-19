// See https://aka.ms/new-console-template for more information

using Ejercicio103._1;

clsPersona[] personas = new clsPersona[5];

Console.WriteLine("Ingrese los datos de la persona: ");

for  (int i = 0; i < personas.Length; i++)
{
    personas[i] = new clsPersona();

    Console.WriteLine("Nombre: ");
    personas[i].Nombre = Console.ReadLine();

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