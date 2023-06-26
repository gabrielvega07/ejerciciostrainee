using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Final
{
    class Agenda
{
    private List<Contacto> contactos;

    public Agenda()
    {
        contactos = new List<Contacto>();
        CargarContactos();
    }

    public void AgregarCita()
    {
        Console.WriteLine("----- Añadir cita -----");
        Console.Write("Introduce la fecha de la cita (día, mes, año, hora, minuto): ");
        string fechaCita = Console.ReadLine();
        Console.Write("Introduce la descripción de la cita: ");
        string descripcion = Console.ReadLine();
        Console.Write("Introduce el nombre de la persona con quien tienes la cita: ");
        string nombrePersona = Console.ReadLine();

        List<Contacto> contactosEncontrados = BuscarContactoPorNombre(nombrePersona);

        if (contactosEncontrados.Count > 0)
        {
            Console.WriteLine("Se encontraron los siguientes contactos:");
            MostrarContactos(contactosEncontrados);

            Console.Write("Introduce el número del contacto: ");
            int numeroContacto;
            if (int.TryParse(Console.ReadLine(), out numeroContacto))
            {
                if (numeroContacto >= 1 && numeroContacto <= contactosEncontrados.Count)
                {
                    Contacto contactoSeleccionado = contactosEncontrados[numeroContacto - 1];

                    Cita cita = new Cita(fechaCita, descripcion, contactoSeleccionado);
                    GuardarCita(cita);

                    Console.WriteLine("La cita se ha guardado correctamente.");
                }
                else
                {
                    Console.WriteLine("Número de contacto no válido.");
                }
            }
            else
            {
                Console.WriteLine("Número de contacto no válido.");
            }
        }
        else
        {
            Console.WriteLine("No se encontró ningún contacto con ese nombre. Primero debes agregar el contacto.");
            AgregarContacto();
        }
    }

    public void AgregarContacto()
    {
        Console.WriteLine("----- Añadir contacto -----");
        Console.Write("Introduce el nombre del contacto: ");
        string nombre = Console.ReadLine();
        Console.Write("Introduce los apellidos del contacto: ");
        string apellidos = Console.ReadLine();
        Console.Write("Introduce el número de teléfono del contacto: ");
        string telefono = Console.ReadLine();
        Console.Write("Introduce la localidad del contacto: ");
        string localidad = Console.ReadLine();

        Contacto contacto = new Contacto(nombre, apellidos, telefono, localidad);
        contactos.Add(contacto);
        GuardarContacto(contacto);

        Console.WriteLine("El contacto se ha guardado correctamente.");
    }

    public void ConsultarCita()
    {
        Console.WriteLine("----- Consultar cita -----");
        Console.WriteLine("1- Consulta por fecha");
        Console.WriteLine("2- Consulta por contacto");
        Console.Write("Selecciona una opción: ");
        string opcionConsulta = Console.ReadLine();
        Console.WriteLine();

        switch (opcionConsulta)
        {
            case "1":
                Console.Write("Introduce la fecha de la cita (día, mes, año): ");
                string fechaCita = Console.ReadLine();
                List<Cita> citasPorFecha = BuscarCitaPorFecha(fechaCita);
                if (citasPorFecha.Count > 0)
                {
                    Console.WriteLine("Citas para la fecha especificada:");
                    MostrarCitas(citasPorFecha);
                }
                else
                {
                    Console.WriteLine("No se encontraron citas para la fecha especificada.");
                }
                break;
            case "2":
                Console.Write("Introduce el nombre del contacto: ");
                string nombreContacto = Console.ReadLine();
                List<Contacto> contactosEncontrados = BuscarContactoPorNombre(nombreContacto);
                if (contactosEncontrados.Count > 0)
                {
                    Console.WriteLine("Se encontraron los siguientes contactos:");
                    MostrarContactos(contactosEncontrados);

                    Console.Write("Introduce el número del contacto: ");
                    int numeroContacto;
                    if (int.TryParse(Console.ReadLine(), out numeroContacto))
                    {
                        if (numeroContacto >= 1 && numeroContacto <= contactosEncontrados.Count)
                        {
                            Contacto contactoSeleccionado = contactosEncontrados[numeroContacto - 1];
                            List<Cita> citasPorContacto = BuscarCitaPorContacto(contactoSeleccionado);
                            if (citasPorContacto.Count > 0)
                            {
                                Console.WriteLine("Citas para el contacto especificado:");
                                MostrarCitas(citasPorContacto);
                            }
                            else
                            {
                                Console.WriteLine("No se encontraron citas para el contacto especificado.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Número de contacto no válido.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Número de contacto no válido.");
                    }
                }
                else
                {
                    Console.WriteLine("No se encontró ningún contacto con ese nombre.");
                }
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, selecciona una opción válida.");
                break;
        }
    }

    public void BuscarContacto()
    {
        Console.WriteLine("----- Buscar contacto -----");
        Console.Write("Introduce el nombre del contacto: ");
        string nombreContacto = Console.ReadLine();
        List<Contacto> contactosEncontrados = BuscarContactoPorNombre(nombreContacto);
        if (contactosEncontrados.Count > 0)
        {
            Console.WriteLine("Contactos encontrados:");
            MostrarContactos(contactosEncontrados);
        }
        else
        {
            Console.WriteLine("No se encontraron contactos con ese nombre.");
        }
    }

    private void CargarContactos()
    {
        try
        {
            if (File.Exists("contactos.txt"))
            {
                using (StreamReader sr = new StreamReader("contactos.txt"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] campos = linea.Split(',');
                        string nombre = campos[0];
                        string apellidos = campos[1];
                        string telefono = campos[2];
                        string localidad = campos[3];

                        Contacto contacto = new Contacto(nombre, apellidos, telefono, localidad);
                        contactos.Add(contacto);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al cargar los contactos: " + ex.Message);
        }
    }

    private void GuardarContacto(Contacto contacto)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter("contactos.txt", true))
            {
                sw.WriteLine(contacto.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al guardar el contacto: " + ex.Message);
        }
    }

    private List<Contacto> BuscarContactoPorNombre(string nombre)
    {
        List<Contacto> contactosEncontrados = new List<Contacto>();

        foreach (Contacto contacto in contactos)
        {
            if (contacto.NombreCompleto.ToLower().Contains(nombre.ToLower()))
            {
                contactosEncontrados.Add(contacto);
            }
        }

        return contactosEncontrados;
    }

    private void MostrarContactos(List<Contacto> contactos)
    {
        for (int i = 0; i < contactos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {contactos[i].ToString()}");
        }
    }

    private void GuardarCita(Cita cita)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter("agenda.txt", true))
            {
                sw.WriteLine(cita.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al guardar la cita: " + ex.Message);
        }
    }

    private List<Cita> BuscarCitaPorFecha(string fecha)
    {
        List<Cita> citasEncontradas = new List<Cita>();

        try
        {
            if (File.Exists("agenda.txt"))
            {
                using (StreamReader sr = new StreamReader("agenda.txt"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] campos = linea.Split(',');

                        string fechaCita = campos[0];
                        string descripcion = campos[1];

                        string nombre = campos[2];
                        string apellidos = campos[3];
                        string telefono = campos[4];
                        string localidad = campos[5];

                        Contacto contacto = new Contacto(nombre, apellidos, telefono, localidad);
                        Cita cita = new Cita(fechaCita, descripcion, contacto);

                        if (fechaCita.Contains(fecha))
                        {
                            citasEncontradas.Add(cita);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al buscar las citas por fecha: " + ex.Message);
        }

        return citasEncontradas;
    }

    private List<Cita> BuscarCitaPorContacto(Contacto contacto)
    {
        List<Cita> citasEncontradas = new List<Cita>();

        try
        {
            if (File.Exists("agenda.txt"))
            {
                using (StreamReader sr = new StreamReader("agenda.txt"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] campos = linea.Split(',');

                        string fechaCita = campos[0];
                        string descripcion = campos[1];

                        string nombre = campos[2];
                        string apellidos = campos[3];
                        string telefono = campos[4];
                        string localidad = campos[5];

                        Contacto contactoCita = new Contacto(nombre, apellidos, telefono, localidad);
                        Cita cita = new Cita(fechaCita, descripcion, contactoCita);

                        if (contacto.Equals(contactoCita))
                        {
                            citasEncontradas.Add(cita);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al buscar las citas por contacto: " + ex.Message);
        }

        return citasEncontradas;
    }

    private void MostrarCitas(List<Cita> citas)
    {
        foreach (Cita cita in citas)
        {
            Console.WriteLine(cita.ToString());
        }
    }
}
}
