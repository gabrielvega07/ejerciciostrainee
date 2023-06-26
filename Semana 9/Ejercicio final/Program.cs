using Ejercicio_Final;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        Agenda agenda = new Agenda();
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("----- MENÚ -----");
            Console.WriteLine("1-Añadir cita");
            Console.WriteLine("2-Añadir contacto");
            Console.WriteLine("3-Consultar cita");
            Console.WriteLine("4-Buscar contacto");
            Console.WriteLine("0-Salir");
            Console.Write("Selecciona una opción: ");
            string opcion = Console.ReadLine();
            Console.WriteLine();

            switch (opcion)
            {
                case "1":
                    agenda.AgregarCita();
                    break;
                case "2":
                    agenda.AgregarContacto();
                    break;
                case "3":
                    agenda.ConsultarCita();
                    break;
                case "4":
                    agenda.BuscarContacto();
                    break;
                case "0":
                    Console.Write("¿Estás seguro de que deseas salir? (S/N): ");
                    string respuesta = Console.ReadLine().ToUpper();
                    if (respuesta == "S")
                    {
                        salir = true;
                        Console.WriteLine("¡Hasta luego!");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, selecciona una opción válida.");
                    break;
            }

            Console.WriteLine();
        }
    }
}