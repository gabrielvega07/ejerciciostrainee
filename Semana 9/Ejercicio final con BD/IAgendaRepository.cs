using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    interface IAgendaRepository
    {
        void AddCita(Cita cita);
        void AddContacto(Contacto contacto);
        List<Cita> GetCitasByFecha(string fecha);
        List<Cita> GetCitasByContacto(Contacto contacto);
        List<Contacto> GetContactosByNombre(string nombre);
    }
}
