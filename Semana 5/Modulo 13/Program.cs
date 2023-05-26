// See https://aka.ms/new-console-template for more information

using Ejercicio139;

string rutaArchivo = "perosona.txt";

List<clsPersona> personas = new List<clsPersona>();

do
{
    Console.WriteLine("Ingresar nombre de la persona: ");
    string nombre = Console.ReadLine();

    Console.WriteLine("Ingresar la edad de la persona");
    int edad;

    while (!int.TryParse(Console.ReadLine(), out edad) || edad <= 0)
    {
        Console.WriteLine("Edad invalida.");
        Console.WriteLine("Ingresar la edad de la persona: ");
    }

    Console.Write("Ingrese la localidad de la persona: ");
    string localidad = Console.ReadLine();

    // Crear instancia de Persona
    clsPersona persona = new clsPersona(nombre, edad, localidad);
    personas.Add(persona);

    Console.Write("¿Desea introducir más personas? (S/N): ");

}

while (Console.ReadLine().ToUpper() == "S");

GuardarPersonasEnArchivo(personas, rutaArchivo);

Console.WriteLine("\nPersonas registradas: ");

//para mostrar las personas

List<clsPersona> todasLasPersonas = ObtenerTodasLasPersonasDesdeArchivo(rutaArchivo);
if (todasLasPersonas.Count > 0)
{
    foreach (clsPersona perosona in todasLasPersonas)
    {
        Console.WriteLine("Nombre: {0}, Edad: {1}, Localidad: {2}", perosona.Nombre, perosona.Edad, perosona.Localidad);
    }
}

else
{
    Console.WriteLine("No hay personas registradas");
}

Console.ReadLine();


// Método para guardar las personas en un archivo
static void GuardarPersonasEnArchivo(List<clsPersona> personas, string rutaArchivo)
{
    try
    {
        using (StreamWriter escritor = new StreamWriter(rutaArchivo, true))
        {
            foreach (clsPersona persona in personas)
            {
                escritor.WriteLine(persona.ObtenerCadenaPersona());
            }
        }
        Console.WriteLine("Las personas se han guardado correctamente en el archivo.");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error al guardar las personas en el archivo: " + ex.Message);
    }
}


// Método para obtener todas las personas desde el archivo
static List<clsPersona> ObtenerTodasLasPersonasDesdeArchivo(string rutaArchivo)
{
    List<clsPersona> personas = new List<clsPersona>();
    try
    {
        using (StreamReader lector = new StreamReader(rutaArchivo))
        {
            string linea;
            while ((linea = lector.ReadLine()) != null)
            {
                string[] datosPersona = linea.Split('|');
                if (datosPersona.Length == 3)
                {
                    string nombre = datosPersona[0];
                    int edad;
                    int.TryParse(datosPersona[1], out edad);
                    string localidad = datosPersona[2];

                    clsPersona persona = new clsPersona(nombre, edad, localidad);
                    personas.Add(persona);
                }
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error al leer el archivo: " + ex.Message);
    }
    return personas;
}