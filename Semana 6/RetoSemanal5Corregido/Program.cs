using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

Console.WriteLine("¡Bienvenido al juego R5.1");

// Crear o cargar la lista de jugadores desde el archivo binario
List<Jugador> jugadores = CargarJugadores();

bool salir = false;

while (!salir)
{
    Console.WriteLine();
    Console.WriteLine("MENU PRINCIPAL");
    Console.WriteLine("1. Ingresar un nuevo jugador");
    Console.WriteLine("2. Buscar un jugador");
    Console.WriteLine("3. Salir");
    Console.Write("Ingrese una opción: ");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            // Ingresar un nuevo jugador
            Jugador nuevoJugador = CrearJugador();
            jugadores.Add(nuevoJugador);
            GuardarJugadores(jugadores);
            Console.WriteLine("Jugador ingresado exitosamente.");
            break;
        case "2":
            // Buscar un jugador
            Console.Write("Ingrese el nombre del jugador que desea buscar: ");
            string nombreJugador = Console.ReadLine();
            BuscarJugadores(jugadores, nombreJugador);
            break;

        case "3":
            // Salir del programa
            salir = true;
            Console.WriteLine("¡Gracias por jugar!");
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, ingrese una opción válida.");
            break;
    }
}

static List<Jugador> CargarJugadores()
{
    List<Jugador> jugadores;

    if (File.Exists("jugadores.bin"))
    {
        // Si el archivo existe, cargar la lista de jugadores desde el archivo
        using (FileStream stream = new FileStream("jugadores.bin", FileMode.Open))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            jugadores = (List<Jugador>)formatter.Deserialize(stream);
        }
    }
    else
    {
        // Si el archivo no existe, crear una nueva lista de jugadores vacía
        jugadores = new List<Jugador>();
    }

    return jugadores;
}

static void GuardarJugadores(List<Jugador> jugadores)
{
    using (FileStream stream = new FileStream("jugadores.bin", FileMode.Create))
    {
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream, jugadores);
    }
}

static Jugador CrearJugador()
{
    Console.WriteLine("Crear nuevo jugador");

    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();

    Console.Write("Nivel: ");
    int nivel = int.Parse(Console.ReadLine());

    Console.Write("Puntos de vida: ");
    int puntosDeVida = int.Parse(Console.ReadLine());

    Console.Write("Número de reinicios: ");
    int numeroDeReinicios = int.Parse(Console.ReadLine());

    return new Jugador(nombre, nivel, puntosDeVida, numeroDeReinicios);
}

static List<Jugador> BuscarJugadores(List<Jugador> jugadores, string nombre)
{
    List<Jugador> jugadoresEncontrados = new List<Jugador>();
    foreach (Jugador jugador in jugadores)
    {
        if (jugador.Nombre.ToLower().Contains(nombre.ToLower()))
        {
            jugadoresEncontrados.Add(jugador);
        }
    }
    if (jugadoresEncontrados.Count > 0)
    {
        Console.WriteLine("Jugadores encontrados:");
        foreach (Jugador jugador in jugadoresEncontrados)
        {
            Console.WriteLine("\nNombre: " + jugador.Nombre);
            Console.WriteLine("Nivel: " + jugador.Nivel);
            Console.WriteLine("Puntos de vida: " + jugador.PuntosDeVida);
            Console.WriteLine("Número de reinicios: " + jugador.NumeroDeReinicios);
            Console.WriteLine("-----------------------\n");
        }
    }
    else
    {
        Console.WriteLine("\nNo se encontraron jugadores con ese nombre.\n");
    }

    return jugadoresEncontrados;
}
