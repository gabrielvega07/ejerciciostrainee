using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSemana4
{
    // Interfaz IBiblioteca
    interface IBiblioteca
    {
        void AgregarMaterial(clsMaterial material);
        List<clsMaterial> BuscarPorTitulo(string titulo);
        void PrestarMaterial(clsMaterial material);
        void DevolverMaterial(clsMaterial material);
    }
}
