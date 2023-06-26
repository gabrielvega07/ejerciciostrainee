using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Contacto
    {
        public int Id { get; }
        public string Nombre { get; }
        public string Apellidos { get; }
        public string Telefono { get; }
        public string Localidad { get; }
        public string NombreCompleto => Nombre + " " + Apellidos;

        public Contacto(int id, string nombre, string apellidos, string telefono, string localidad)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
            Localidad = localidad;
        }

        public Contacto(string nombre, string apellidos, string telefono, string localidad)
            : this(0, nombre, apellidos, telefono, localidad)
        {
        }
    }

}
