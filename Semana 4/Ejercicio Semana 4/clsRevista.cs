using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSemana4
{
    // Clase clsRevista que hereda de clsMaterial
    class clsRevista : clsMaterial
    {
        public int Edicion { get; set; }

        // Constructor
        public clsRevista(string titulo, int edicion) : base(titulo)
        {
            Edicion = edicion;
        }

        // Método para prestar la revista
        public void Prestar()
        {
            if (Disponible)
            {
                Disponible = false;
                Console.WriteLine("La revista '{0}' ha sido prestada.", Titulo);
            }
            else
            {
                Console.WriteLine("La revista '{0}' no está disponible para préstamo.", Titulo);
            }
        }
    }
}
