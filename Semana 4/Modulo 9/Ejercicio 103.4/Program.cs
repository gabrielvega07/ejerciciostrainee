// See https://aka.ms/new-console-template for more information

using Ejercicio103._4;

clsVehiculo coche = new clsVehiculo(4, 4);
Console.WriteLine($"Coche tiene: Ruedas = {coche.Ruedas}, Puertas = {coche.Puertas}");

clsVehiculo avion = new clsVehiculo(3, 1);
Console.WriteLine($"Avion tiene: Ruedas = {avion.Ruedas}, Puertas = {avion.Puertas}");

clsVehiculo bicileta = new clsVehiculo(2);
Console.WriteLine($"Bicicleta tiene: Ruedas = {bicileta.Ruedas}, Puertas = {bicileta.Puertas}");

Console.ReadKey();
