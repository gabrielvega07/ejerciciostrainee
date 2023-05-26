using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// Clase clsLibro que hereda de clsMaterial

namespace EjercicioSemana4
{
    class clsLibro : clsMaterial
    {
        public string Autor { get; set; }

        // Constructor
        public clsLibro(string titulo, string autor) : base(titulo)
        {
            Autor = autor;
        }

        // Método para prestar el libro
        public void Prestar()
        {
            if (Disponible)
            {
                Disponible = false;
                Console.WriteLine("El libro '{0}' ha sido prestado.", Titulo);
            }
            else
            {
                Console.WriteLine("El libro '{0}' no está disponible para préstamo.", Titulo);
            }
        }

        // Método para devolver el libro
        public void Devolver()
        {
            if (!Disponible)
            {
                Disponible = true;
                Console.WriteLine("El libro '{0}' ha sido devuelto.", Titulo);
            }
            else
            {
                Console.WriteLine("El libro '{0}' no se puede devolver porque no estaba prestado.", Titulo);
            }
        }
    }
}
