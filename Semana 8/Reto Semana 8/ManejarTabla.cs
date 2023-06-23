using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos
{
    class ManejarTabla
    {
        private string connectionString;
        private string tabla;

        public ManejarTabla(string connectionString, string tabla)
        {
            this.connectionString = connectionString;
            this.tabla = tabla;
        }

        public void EliminarTabla()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"IF OBJECT_ID(N'[dbo].[{tabla}]', N'U') IS NOT NULL DROP TABLE [dbo].[{tabla}]";
                    command.ExecuteNonQuery();
                }
            }
        }

        public void CrearTabla()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"CREATE TABLE [dbo].[{tabla}](" +
                        $"[id] INT PRIMARY KEY," +
                        $"[origen] VARCHAR(MAX)," +
                        $"[destino] VARCHAR(MAX)," +
                        $"[fecha] VARCHAR(MAX)," +
                        $"[precio] VARCHAR(MAX)," +
                        $"[aereopuerto] VARCHAR(MAX)" +
                        $")";
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
