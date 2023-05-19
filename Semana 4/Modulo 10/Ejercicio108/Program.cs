// See https://aka.ms/new-console-template for more information

using Ejercicio108;

clsAnimal animal  = new clsAnimal();

animal.Andar();

bool esPerro = animal.EsPerro();

Console.WriteLine($"El animal es perro? {esPerro}");

animal.Saltar();

Console.ReadLine();

