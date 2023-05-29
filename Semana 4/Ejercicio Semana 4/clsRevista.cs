using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoSemanal4
{
    // Clase Revista que hereda de clsMaterial
    class Revista : clsMaterial
    {
        public string Edicion { get; set; }

        public Revista(string titulo, string edicion) : base(titulo)
        {
            Edicion = edicion;
        }

        public void Prestar()
        {
            if (Disponible)
            {
                Disponible = false;
                Console.WriteLine("La revista '{0}' ha sido prestada.", Titulo);
            }
            else
            {
                Console.WriteLine("La revista '{0}' no está disponible actualmente.", Titulo);
            }
        }

        public override string ToString()
        {
            return $"Revista: {Titulo} (Edición: {Edicion})";
        }
    }

}
