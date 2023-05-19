// See https://aka.ms/new-console-template for more information


using Ejercicio103._3;

clsVehiculo vehiculo = new clsVehiculo();
vehiculo.Desplazarse();

clsCoche coche  = new clsCoche();
coche.Desplazarse();

clsBarco barco = new clsBarco();
barco.Desplazarse();

clsAvion avion = new clsAvion();    
avion.Desplazarse();


vehiculo.Detenerse();

coche.Detenerse();

barco.Detenerse();

avion.Detenerse();


Console.ReadLine    ();