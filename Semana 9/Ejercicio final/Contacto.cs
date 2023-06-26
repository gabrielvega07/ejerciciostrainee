using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Final
{
class Contacto
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Telefono { get; set; }
    public string Localidad { get; set; }

    public Contacto(string nombre, string apellidos, string telefono, string localidad)
    {
        Nombre = nombre;
        Apellidos = apellidos;
        Telefono = telefono;
        Localidad = localidad;
    }

    public string NombreCompleto
    {
        get { return $"{Nombre} {Apellidos}"; }
    }

    public override string ToString()
    {
        return $"{NombreCompleto} - Teléfono: {Telefono} - Localidad: {Localidad}";
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Contacto otroContacto = (Contacto)obj;

        return Nombre.Equals(otroContacto.Nombre) && Apellidos.Equals(otroContacto.Apellidos);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Nombre, Apellidos);
    }
}
}
