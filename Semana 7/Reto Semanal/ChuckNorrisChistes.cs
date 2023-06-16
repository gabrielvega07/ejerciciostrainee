using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ObtnerChiste
{
    class ChuckNorrisChistes
    {
        private string filePath;

        public ChuckNorrisChistes(string filePath)
        {
            this.filePath = filePath;
        }

        public void Run()
        {
            // Verificar si el archivo existe
            if (!File.Exists(filePath))
            {
                // Crear el archivo si no existe
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    writer.Close();
                }
            }
            Console.WriteLine("Obten un chiste aleatorio de Chuck Norris!");
            Console.WriteLine("1. Obtener un chiste aleatorio");
            Console.WriteLine("2. Buscar chistes por una palabra clave");
            Console.WriteLine("3. Salir del programa");

            bool exit = false;
            while (!exit)
            {
                Console.Write("Ingrese su opción: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        ObtenerChisteAleatorio();
                        break;
                    case "2":
                        Console.Write("Ingrese la palabra clave: ");
                        string palabraClave = Console.ReadLine();
                        BuscarChistes(palabraClave);
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
        }

        private void ObtenerChisteAleatorio()
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    // Realizar la petición GET a la API de Chuck Norris para obtener un chiste aleatorio
                    string response = client.DownloadString("https://api.chucknorris.io/jokes/random");

                    // Deserializar el JSON y obtener solo el valor del chiste
                    dynamic result = JsonConvert.DeserializeObject(response);
                    string chiste = result.value;

                    // Validar si el chiste ya existe en el archivo
                    if (BuscarChisteEnArchivo(chiste))
                    {
                        Console.WriteLine("El chiste ya existe en el archivo.");
                    }
                    else
                    {
                        // Guardar el chiste en el archivo de texto
                        using (StreamWriter writer = File.AppendText(filePath))
                        {
                            writer.WriteLine(chiste);
                            writer.Close(); // Cerrar el StreamWriter
                            Console.WriteLine("Chiste guardado correctamente.");

                            // Mostrar el chiste guardado
                            Console.WriteLine("Chiste guardado:");
                            Console.WriteLine(chiste + "\n");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener el chiste: " + ex.Message);
                }
            }
        }

        private void BuscarChistes(string palabraClave)
        {
            string[] chistes = File.ReadAllLines(filePath, Encoding.UTF8);
            bool found = false;

            foreach (string chiste in chistes)
            {
                string chsiteNormalizado = chiste.ToLower();
                string palabraClaveNormalizada = palabraClave.ToLower();

                if (chsiteNormalizado.Contains(palabraClaveNormalizada))
                {
                    Console.WriteLine(chiste + "\n");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No se encontraron chistes con la palabra clave proporcionada.");
            }
        }

        private bool BuscarChisteEnArchivo(string chiste)
        {
            string[] chistes = File.ReadAllLines(filePath, Encoding.UTF8);

            foreach (string chistesAlmacenados in chistes)
            {
                if (chistesAlmacenados.Equals(chiste))
                {
                    return true;
                }
            }

            return false;
        }
    }
}