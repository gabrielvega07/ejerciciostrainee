using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio125._2
{
    class clsListado<T>
    {
        private List<T> listado;

        public clsListado()
        {
            listado = new List<T>();

        }

        public void AgrgarValor(T valor)
        {
            listado.Add(valor);
        }

        public void MostrarLista()
        {
            Console.WriteLine("Lista: ");
            foreach (T valor in listado)
            {
                Console.WriteLine(valor);
            }
        }
    }
}
