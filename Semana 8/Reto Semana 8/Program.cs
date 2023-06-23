using Vuelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=msserver11.database.windows.net;Initial Catalog=DBAzure;User ID=Gabriel;Password=2125Pablo/;Connect Timeout=30;Encrypt=True;";
        //string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDVuelos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        
        string tabla = "Vuelos";

        string rutaArchivo = "C:\\.Net\\Vuelos disponibles.csv";

        ManejarDatos dataManager = new ManejarDatos(connectionString, tabla);
        ManejarTabla tableCreator = new ManejarTabla(connectionString, tabla);

        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("******** MENU DE VUELOS ********");
            Console.WriteLine("1. Cargar datos desde archivo CSV");
            Console.WriteLine("2. Consultar por origen");
            Console.WriteLine("3. Consultar por destino");
            Console.WriteLine("4. Salir");
            Console.WriteLine("*********************************");
            Console.Write("Ingrese una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    tableCreator.EliminarTabla();
                    tableCreator.CrearTabla();
                    dataManager.CargarDatosDesdeCSV(rutaArchivo);
                    Console.WriteLine("Datos cargados correctamente.");
                    break;
                case "2":
                    Console.Write("Ingrese el origen: ");
                    string origen = Console.ReadLine();
                    List<DatosVuelo> vuelosOrigen = dataManager.ConsultarPorOrigen(origen);
                    Console.WriteLine("Vuelos desde el origen '{0}':", origen);
                    ImprimirVuelos(vuelosOrigen);
                    break;
                case "3":
                    Console.Write("Ingrese el destino: ");
                    string destino = Console.ReadLine();
                    List<DatosVuelo> vuelosDestino = dataManager.ConsultarPorDestino(destino);
                    Console.WriteLine("Vuelos hacia el destino '{0}':", destino);
                    ImprimirVuelos(vuelosDestino);
                    break;
                case "4":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, ingrese un número válido.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void ImprimirVuelos(List<DatosVuelo> vuelos)
    {
        foreach (DatosVuelo vuelo in vuelos)
        {
            Console.WriteLine(vuelo.ToString());
        }
    }
}



