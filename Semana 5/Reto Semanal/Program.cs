// See https://aka.ms/new-console-template for more information


using EjerccioSemana5;

Console.WriteLine("Bienvenido al juego R5");

// Crear un nuevo jugador
clsJugador jugador = CrearJugador();

// Guardar los datos del jugador en un archivo binario
Console.WriteLine("Guardando datos del jugador...");
jugador.GuardarDatos("datosJugador.bin");

// Cargar los datos del jugador desde un archivo binario
Console.WriteLine("Cargando datos del jugador...");
clsJugador jugadorCargado = clsJugador.CargarDatos("datosJugador.bin");

// Verificar si se cargaron correctamente los datos del jugador
if (jugadorCargado != null)
{
    Console.WriteLine("Datos del jugador cargados correctamente:");
    Console.WriteLine($"Nombre: {jugadorCargado.Nombre}");
    Console.WriteLine($"Nivel: {jugadorCargado.Nivel}");
    Console.WriteLine($"Puntos de vida: {jugadorCargado.PuntosDeVida}");
    Console.WriteLine($"Número de reinicios: {jugadorCargado.NumeroDeReinicios}");
}

Console.WriteLine("¡Fin del programa!");
Console.ReadLine();

static clsJugador CrearJugador()
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

    return new clsJugador(nombre, nivel, puntosDeVida, numeroDeReinicios);

}