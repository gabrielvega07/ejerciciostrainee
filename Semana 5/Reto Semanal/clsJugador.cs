using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EjerccioSemana5
{
    [Serializable]
    public class clsJugador
    {
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public int PuntosDeVida { get; set; }
        public int NumeroDeReinicios { get; set; }

        // Constructor de la clase
        public clsJugador(string nombre, int nivel, int puntosDeVida, int numeroDeReinicios)
        {
            Nombre = nombre;
            Nivel = nivel;
            PuntosDeVida = puntosDeVida;
            NumeroDeReinicios = numeroDeReinicios;
        }

        // Método para guardar los datos del jugador en un archivo binario
        public void GuardarDatos(string filePath)
        {
            try
            {
                // Crear una instancia del formateador binario
                BinaryFormatter formatter = new BinaryFormatter();

                // Crear un flujo de salida para el archivo
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    // Serializar el objeto clsJugador y escribirlo en el archivo
                    formatter.Serialize(stream, this);
                }

                Console.WriteLine("Datos del jugador guardados correctamente.");
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error al jugador
                Console.WriteLine("Error al guardar los datos del jugador. Por favor, intenta nuevamente.");

                // Registrar los detalles del error en un archivo de registro
                string logFilePath = "error.log";
                string errorMessage = $"Fecha y hora: {DateTime.Now}\nMensaje de error: {ex.Message}\nDetalles: {ex.StackTrace}\n";
                File.AppendAllText(logFilePath, errorMessage);
            }
        }

        // Método para cargar los datos del jugador desde un archivo binario
        public static clsJugador CargarDatos(string filePath)
        {
            try
            {
                // Crear una instancia del formateador binario
                BinaryFormatter formatter = new BinaryFormatter();

                // Verificar si el archivo existe
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("El archivo de datos del jugador no existe.");
                    return null;
                }

                // Crear un flujo de entrada para el archivo
                using (FileStream stream = new FileStream(filePath, FileMode.Open))
                {
                    // Deserializar el objeto clsJugador desde el archivo
                    clsJugador jugador = (clsJugador)formatter.Deserialize(stream);
                    return jugador;
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error al jugador
                Console.WriteLine("Error al cargar los datos del jugador. Por favor, intenta nuevamente.");

                // Registrar los detalles del error en un archivo de registro
                string logFilePath = "error.log";
                string errorMessage = $"Fecha y hora: {DateTime.Now}\nMensaje de error: {ex.Message}\nDetalles: {ex.StackTrace}\n";
                File.AppendAllText(logFilePath, errorMessage);

                return null;
            }
        }

        // Otros métodos y funcionalidades de la clase
    }
}
