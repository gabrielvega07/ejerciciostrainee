using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Final
{
    class Cita
{
    public string Fecha { get; set; }
    public string Descripcion { get; set; }
    public Contacto Contacto { get; set; }

    public Cita(string fecha, string descripcion, Contacto contacto)
    {
        Fecha = fecha;
        Descripcion = descripcion;
        Contacto = contacto;
    }

    public override string ToString()
    {
        return $"Fecha: {Fecha} - Descripción: {Descripcion} - Contacto: {Contacto.NombreCompleto} - Teléfono: {Contacto.Telefono} - Localidad: {Contacto.Localidad}";
    }
}

}
