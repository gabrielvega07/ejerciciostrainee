using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos
{
    class DatosVuelo
    {
        public int Id { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Fecha { get; set; }
        public string Precio { get; set; }
        public string Aeropuerto { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Origen: {Origen}, Destino: {Destino}, Fecha: {Fecha}, Precio: {Precio}, Aeropuerto: {Aeropuerto}";
        }
    }
}
