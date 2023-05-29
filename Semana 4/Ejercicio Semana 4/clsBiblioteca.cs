using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoSemanal4
{
    // Clase clsBiblioteca que implementa IBiblioteca
    class clsBiblioteca : IBiblioteca
    {
        private List<clsMaterial> materiales;

        public clsBiblioteca()
        {
            materiales = new List<clsMaterial>();
        }

        public void AgregarMaterial(clsMaterial material)
        {
            materiales.Add(material);
            Console.WriteLine("Se agregó el material '{0}' a la biblioteca.", material.Titulo);
        }

        public List<clsMaterial> BuscarPorTitulo(string titulo)
        {
            List<clsMaterial> resultados = new List<clsMaterial>();
            foreach (clsMaterial material in materiales)
            {
                if (material.Titulo.ToLower().Contains(titulo.ToLower()))
                {
                    resultados.Add(material);
                }
            }
            return resultados;
        }

        public void PrestarMaterial(clsMaterial material)
        {
            if (material.Disponible)
            {
                material.Disponible = false;
                Console.WriteLine("Se ha prestado el material: '{0}'", material.Titulo);
                if (material is Libro libro)
                {
                    Console.WriteLine(libro.ToString());
                }

                else if (material is Revista revista)
                {
                    Console.WriteLine(revista.ToString());
                }
            }
            else
            {
                Console.WriteLine("El material '{0}' no está disponible actualmente para préstamo.", material.Titulo);
            }
        }

        public void DevolverMaterial(clsMaterial material)
        {
            if (!material.Disponible)
            {
                material.Disponible = true;
                Console.WriteLine("Se ha devuelto el material: '{0}'", material.Titulo);
            }
            else
            {
                Console.WriteLine("El material '{0}' no está prestado actualmente.", material.Titulo);
            }
        }
    }
}
