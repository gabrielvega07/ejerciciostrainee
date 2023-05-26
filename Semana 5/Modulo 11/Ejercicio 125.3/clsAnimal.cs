using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio125._3
{
    internal class clsAnimal
    {
        public Animales TipoAnimal { get; set; }

        public clsAnimal(Animales tipoAnimal)
        {
            TipoAnimal = tipoAnimal;
        }
    }
}
