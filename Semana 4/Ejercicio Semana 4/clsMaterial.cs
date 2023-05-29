using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoSemanal4
{
    abstract class clsMaterial
    {
        public string Titulo { get; set; }
        public bool Disponible { get; set; }

        public clsMaterial(string titulo)
        {
            Titulo = titulo;
            Disponible = true;
        }
    }
}
