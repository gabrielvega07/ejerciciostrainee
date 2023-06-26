using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class SqlServerAgendaRepository : IAgendaRepository
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDVuelos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public SqlServerAgendaRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddCita(Cita cita)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Cita (Fecha, Descripcion, ContactoId) VALUES (@Fecha, @Descripcion, @ContactoId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Fecha", cita.Fecha);
                command.Parameters.AddWithValue("@Descripcion", cita.Descripcion);
                command.Parameters.AddWithValue("@ContactoId", cita.Contacto.Id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al guardar la cita: " + ex.Message);
                }
            }
        }

        public void AddContacto(Contacto contacto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Contacto (Nombre, Apellidos, Telefono, Localidad) VALUES (@Nombre, @Apellidos, @Telefono, @Localidad)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", contacto.Nombre);
                command.Parameters.AddWithValue("@Apellidos", contacto.Apellidos);
                command.Parameters.AddWithValue("@Telefono", contacto.Telefono);
                command.Parameters.AddWithValue("@Localidad", contacto.Localidad);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al guardar el contacto: " + ex.Message);
                }
            }
        }

        public List<Cita> GetCitasByFecha(string fecha)
        {
            List<Cita> citas = new List<Cita>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Cita.Fecha, Cita.Descripcion, Contacto.Nombre, Contacto.Apellidos, Contacto.Telefono, Contacto.Localidad " +
                               "FROM Cita INNER JOIN Contacto ON Cita.ContactoId = Contacto.Id " +
                               "WHERE CONVERT(VARCHAR(10), Cita.Fecha, 103) = @Fecha";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Fecha", fecha);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string fechaCita = reader["Fecha"].ToString();
                        string descripcionCita = reader["Descripcion"].ToString();
                        string nombreContacto = reader["Nombre"].ToString();
                        string apellidosContacto = reader["Apellidos"].ToString();
                        string telefonoContacto = reader["Telefono"].ToString();
                        string localidadContacto = reader["Localidad"].ToString();

                        Contacto contacto = new Contacto(nombreContacto, apellidosContacto, telefonoContacto, localidadContacto);
                        Cita cita = new Cita(fechaCita, descripcionCita, contacto);
                        citas.Add(cita);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al buscar las citas: " + ex.Message);
                }
            }

            return citas;
        }

        public List<Cita> GetCitasByContacto(Contacto contacto)
        {
            List<Cita> citas = new List<Cita>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Cita.Fecha, Cita.Descripcion, Contacto.Nombre, Contacto.Apellidos, Contacto.Telefono, Contacto.Localidad " +
                               "FROM Cita INNER JOIN Contacto ON Cita.ContactoId = Contacto.Id " +
                               "WHERE Contacto.Id = @ContactoId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ContactoId", contacto.Id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string fechaCita = reader["Fecha"].ToString();
                        string descripcionCita = reader["Descripcion"].ToString();

                        Cita cita = new Cita(fechaCita, descripcionCita, contacto);
                        citas.Add(cita);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al buscar las citas: " + ex.Message);
                }
            }

            return citas;
        }

        public List<Contacto> GetContactosByNombre(string nombre)
        {
            List<Contacto> contactos = new List<Contacto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Nombre, Apellidos, Telefono, Localidad " +
                               "FROM Contacto WHERE Nombre LIKE @Nombre";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int idContacto = int.Parse(reader["Id"].ToString());
                        string nombreContacto = reader["Nombre"].ToString();
                        string apellidosContacto = reader["Apellidos"].ToString();
                        string telefonoContacto = reader["Telefono"].ToString();
                        string localidadContacto = reader["Localidad"].ToString();

                        Contacto contacto = new Contacto(idContacto, nombreContacto, apellidosContacto, telefonoContacto, localidadContacto);
                        contactos.Add(contacto);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al buscar los contactos: " + ex.Message);
                }
            }

            return contactos;
        }
    }

}
