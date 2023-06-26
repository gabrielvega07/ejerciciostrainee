using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "tu_cadena_de_conexion";
            IAgendaRepository repository = new SqlServerAgendaRepository(connectionString);

            while (true)
            {
                MostrarMenu();
                int opcion = LeerOpcion();

                switch (opcion)
                {
                    case 1:
                        AgregarCita(repository);
                        break;
                    case 2:
                        AgregarContacto(repository);
                        break;
                    case 3:
                        ConsultarCitasMenu(repository);
                        break;
                    case 4:
                        BuscarContacto(repository);
                        break;
                    case 0:
                        Console.WriteLine("¿Estás seguro de que deseas salir? (S/N)");
                        string confirmacion = Console.ReadLine().ToUpper();

                        if (confirmacion == "S")
                        {
                            Console.WriteLine("¡Hasta luego!");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Inténtalo nuevamente.");
                        break;
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("=== MENÚ ===");
            Console.WriteLine("1. Añadir cita");
            Console.WriteLine("2. Añadir contacto");
            Console.WriteLine("3. Consultar cita");
            Console.WriteLine("4. Buscar contacto");
            Console.WriteLine("0. Salir");
            Console.WriteLine("=============");
        }

        static int LeerOpcion()
        {
            Console.Write("Ingresa una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return opcion;
        }

        static void AgregarCita(IAgendaRepository repository)
        {
            Console.WriteLine("=== AÑADIR CITA ===");
            Console.Write("Fecha (dd/mm/yyyy): ");
            string fecha = Console.ReadLine();
            Console.Write("Descripción: ");
            string descripcion = Console.ReadLine();
            Console.Write("Nombre del contacto: ");
            string nombreContacto = Console.ReadLine();

            List<Contacto> contactos = repository.GetContactosByNombre(nombreContacto);
            if (contactos.Count == 0)
            {
                Console.WriteLine("No se encontró ningún contacto con ese nombre. Debes añadir el contacto primero.");
                AgregarContacto(repository);
                return;
            }

            Console.WriteLine("Contactos encontrados:");
            MostrarContactos(contactos);

            Console.Write("Ingresa el número del contacto: ");
            int numeroContacto = int.Parse(Console.ReadLine());

            if (numeroContacto < 1 || numeroContacto > contactos.Count)
            {
                Console.WriteLine("Número de contacto inválido.");
                return;
            }

            Contacto contacto = contactos[numeroContacto - 1];
            Cita cita = new Cita(fecha, descripcion, contacto);
            repository.AddCita(cita);

            Console.WriteLine("Cita añadida exitosamente.");
            Console.WriteLine("===================");
        }

        static void AgregarContacto(IAgendaRepository repository)
        {
            Console.WriteLine("=== AÑADIR CONTACTO ===");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellidos: ");
            string apellidos = Console.ReadLine();
            Console.Write("Número de teléfono: ");
            string telefono = Console.ReadLine();
            Console.Write("Localidad: ");
            string localidad = Console.ReadLine();

            Contacto contacto = new Contacto(nombre, apellidos, telefono, localidad);
            repository.AddContacto(contacto);

            Console.WriteLine("Contacto añadido exitosamente.");
            Console.WriteLine("===================");
        }

        static void ConsultarCitasMenu(IAgendaRepository repository)
        {
            Console.WriteLine("=== CONSULTAR CITAS ===");
            Console.WriteLine("1. Consultar por fecha");
            Console.WriteLine("2. Consultar por contacto");
            Console.WriteLine("=======================");

            int opcion = LeerOpcion();

            switch (opcion)
            {
                case 1:
                    ConsultarCitasPorFecha(repository);
                    break;
                case 2:
                    ConsultarCitasPorContacto(repository);
                    break;
                default:
                    Console.WriteLine("Opción inválida. Inténtalo nuevamente.");
                    break;
            }
        }

        static void ConsultarCitasPorFecha(IAgendaRepository repository)
        {
            Console.WriteLine("=== CONSULTAR CITAS POR FECHA ===");
            Console.Write("Fecha (dd/mm/yyyy): ");
            string fecha = Console.ReadLine();

            List<Cita> citas = repository.GetCitasByFecha(fecha);

            if (citas.Count > 0)
            {
                Console.WriteLine("Citas encontradas:");
                MostrarCitas(citas);
            }
            else
            {
                Console.WriteLine("No existen citas para esa fecha.");
            }

            Console.WriteLine("==============================");
        }

        static void ConsultarCitasPorContacto(IAgendaRepository repository)
        {
            Console.WriteLine("=== CONSULTAR CITAS POR CONTACTO ===");
            Console.Write("Nombre del contacto: ");
            string nombreContacto = Console.ReadLine();

            List<Contacto> contactos = repository.GetContactosByNombre(nombreContacto);

            if (contactos.Count == 0)
            {
                Console.WriteLine("No se encontró ningún contacto con ese nombre.");
                return;
            }

            Console.WriteLine("Contactos encontrados:");
            MostrarContactos(contactos);

            Console.Write("Ingresa el número del contacto: ");
            int numeroContacto = int.Parse(Console.ReadLine());

            if (numeroContacto < 1 || numeroContacto > contactos.Count)
            {
                Console.WriteLine("Número de contacto inválido.");
                return;
            }

            Contacto contacto = contactos[numeroContacto - 1];
            List<Cita> citas = repository.GetCitasByContacto(contacto);

            if (citas.Count > 0)
            {
                Console.WriteLine("Citas encontradas:");
                MostrarCitas(citas);
            }
            else
            {
                Console.WriteLine("No existen citas para ese contacto.");
            }

            Console.WriteLine("===============================");
        }

        static void BuscarContacto(IAgendaRepository repository)
        {
            Console.WriteLine("=== BUSCAR CONTACTO ===");
            Console.Write("Nombre del contacto: ");
            string nombre = Console.ReadLine();

            List<Contacto> contactos = repository.GetContactosByNombre(nombre);

            if (contactos.Count > 0)
            {
                Console.WriteLine("Contactos encontrados:");
                MostrarContactos(contactos);
            }
            else
            {
                Console.WriteLine("No se encontraron contactos con ese nombre.");
            }

            Console.WriteLine("======================");
        }

        static void MostrarCitas(List<Cita> citas)
        {
            int contador = 1;
            foreach (Cita cita in citas)
            {
                Console.WriteLine("Cita #" + contador);
                Console.WriteLine("Fecha: " + cita.Fecha);
                Console.WriteLine("Descripción: " + cita.Descripcion);
                Console.WriteLine("Contacto: " + cita.Contacto.NombreCompleto);
                Console.WriteLine("-----------------------");
                contador++;
            }
        }

        static void MostrarContactos(List<Contacto> contactos)
        {
            int contador = 1;
            foreach (Contacto contacto in contactos)
            {
                Console.WriteLine("Contacto #" + contador);
                Console.WriteLine("Nombre: " + contacto.NombreCompleto);
                Console.WriteLine("Teléfono: " + contacto.Telefono);
                Console.WriteLine("Localidad: " + contacto.Localidad);
                Console.WriteLine("-----------------------");
                contador++;
            }
        }
    }
}
