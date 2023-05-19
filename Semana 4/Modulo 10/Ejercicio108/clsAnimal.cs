using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio108
{
    public class clsAnimal : IAnimal
    {
        public void Andar()
        {
            Console.WriteLine("Accion de andar");
        }

        public bool EsPerro()
        {
            Console.WriteLine("Es Perro? s/n:");
            string respuesta = Console.ReadLine();

            return (respuesta.ToLower() == "s");
        }

        public void Saltar()
        {
            Console.WriteLine("El animal esta saltando");
        }
    }
}
