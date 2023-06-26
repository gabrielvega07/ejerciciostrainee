using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Cita
    {
        public string Fecha { get; }
        public string Descripcion { get; }
        public Contacto Contacto { get; }

        public Cita(string fecha, string descripcion, Contacto contacto)
        {
            Fecha = fecha;
            Descripcion = descripcion;
            Contacto = contacto;
        }
    }
}
