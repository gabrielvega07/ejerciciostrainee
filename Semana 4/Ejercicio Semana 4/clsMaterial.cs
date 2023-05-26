using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSemana4
{
    abstract class clsMaterial
    {
        // Clase abstracta clsMaterial
        
            public string Titulo { get; set; }
            public bool Disponible { get; set; }

            // Constructor
            public clsMaterial(string titulo)
            {
                Titulo = titulo;
                Disponible = true; // Por defecto, el material está disponible
            }
        
    }
}
