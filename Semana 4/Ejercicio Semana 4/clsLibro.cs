using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoSemanal4
{
    // Clase Libro que hereda de clsMaterial
    class Libro : clsMaterial
    {
        public string Autor { get; set; }

        public Libro(string titulo, string autor) : base(titulo)
        {
            Autor = autor;
        }

        public void Prestar()
        {
            if (Disponible)
            {
                Disponible = false;
                Console.WriteLine("El libro '{0}' ha sido prestado.", Titulo, Autor);
            }
            else
            {
                Console.WriteLine("El libro '{0}' no está disponible actualmente.", Titulo);
            }
        }

        public void Devolver()
        {
            if (!Disponible)
            {
                Disponible = true;
                Console.WriteLine("El libro '{0}' ha sido devuelto.", Titulo);
            }
            else
            {
                Console.WriteLine("El libro '{0}' ya está disponible en la biblioteca.", Titulo);
            }
        }

        public override string ToString()
        {
            return $"Libro: {Titulo} (Autor: {Autor})";
        }
    }
}
