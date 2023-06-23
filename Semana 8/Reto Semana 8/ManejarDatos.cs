using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos
{
    class ManejarDatos
    {
        private string connectionString;
        private string tabla;

        public ManejarDatos(string connectionString, string tabla)
        {
            this.connectionString = connectionString;
            this.tabla = tabla;
        }

        public void CargarDatosDesdeCSV(string rutaArchivo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;

                    // Leer el archivo CSV
                    using (StreamReader reader = new StreamReader(rutaArchivo))
                    {
                        // Ignorar la primera línea que generalmente contiene los encabezados
                        reader.ReadLine();

                        // Iterar sobre las líneas restantes
                        while (!reader.EndOfStream)
                        {
                            string linea = reader.ReadLine();
                            string[] campos = linea.Split(',');

                            // Insertar los valores en la base de datos
                            command.CommandText = $"INSERT INTO {tabla} (id, origen, destino, fecha, precio, aereopuerto) " +
                                $"VALUES (@id, @origen, @destino, @fecha, @precio, @aereopuerto)";
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@id", campos[0]);
                            command.Parameters.AddWithValue("@origen", campos[1]);
                            command.Parameters.AddWithValue("@destino", campos[2]);
                            command.Parameters.AddWithValue("@fecha", campos[3]);
                            command.Parameters.AddWithValue("@precio", campos[4]);
                            command.Parameters.AddWithValue("@aereopuerto", campos[5]);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public List<DatosVuelo> ConsultarPorOrigen(string origen)
        {
            List<DatosVuelo> vuelos = new List<DatosVuelo>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"SELECT * FROM {tabla} WHERE origen = @origen";
                    command.Parameters.AddWithValue("@origen", origen);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DatosVuelo vuelo = new DatosVuelo()
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Origen = reader["origen"].ToString(),
                                Destino = reader["destino"].ToString(),
                                Fecha = reader["fecha"].ToString(),
                                Precio = reader["precio"].ToString(),
                                Aeropuerto = reader["aereopuerto"].ToString()
                            };

                            vuelos.Add(vuelo);
                        }
                    }
                }
            }

            return vuelos;
        }

        public List<DatosVuelo> ConsultarPorDestino(string destino)
        {
            List<DatosVuelo> vuelos = new List<DatosVuelo>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"SELECT * FROM {tabla} WHERE destino = @destino";
                    command.Parameters.AddWithValue("@destino", destino);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DatosVuelo vuelo = new DatosVuelo()
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Origen = reader["origen"].ToString(),
                                Destino = reader["destino"].ToString(),
                                Fecha = reader["fecha"].ToString(),
                                Precio = reader["precio"].ToString(),
                                Aeropuerto = reader["aereopuerto"].ToString()
                            };

                            vuelos.Add(vuelo);
                        }
                    }
                }
            }

            return vuelos;
        }
    }
}
