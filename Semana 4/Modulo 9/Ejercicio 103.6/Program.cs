// See https://aka.ms/new-console-template for more information

using Ejercicio103._6;

clsAnimal animal1 = new clsAnimal();
animal1.Tipo = "Gato";
animal1.ColorDePelo = "Blanco";
animal1.Domestico = true;
animal1.NumeroPatas = 4;
animal1.Nombre = "Mito";


Console.WriteLine($"Su nombre es: {animal1.Nombre}");
Console.WriteLine($"Tipo: {animal1.Tipo}");
Console.WriteLine($"Color de Pelo: {animal1.ColorDePelo}");
Console.WriteLine($"Es Doméstico: {animal1.Domestico}");
Console.WriteLine($"Número de Patas: {animal1.NumeroPatas}");
