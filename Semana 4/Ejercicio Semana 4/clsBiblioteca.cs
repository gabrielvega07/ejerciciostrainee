using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSemana4
{
    // Clase clsBiblioteca que implementa la interfaz IBiblioteca
    class clsBiblioteca : IBiblioteca
    {
        private List<clsMaterial> materiales;

        // Constructor
        public clsBiblioteca()
        {
            materiales = new List<clsMaterial>();
        }

        // Implementación de los métodos de la interfaz IBiblioteca
        public void AgregarMaterial(clsMaterial material)
        {
            materiales.Add(material);
            Console.WriteLine("Se ha agregado un nuevo material a la biblioteca: '{0}'", material.Titulo);
        }

        public List<clsMaterial> BuscarPorTitulo(string titulo)
        {
            List<clsMaterial> resultados = new List<clsMaterial>();

            foreach (clsMaterial material in materiales)
            {
                if (material.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
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
            }
            else
            {
                Console.WriteLine("El material '{0}' no está disponible para préstamo.", material.Titulo);
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
                Console.WriteLine("El material '{0}' no se puede devolver porque no estaba prestado.", material.Titulo);
            }
        }
    }
}
