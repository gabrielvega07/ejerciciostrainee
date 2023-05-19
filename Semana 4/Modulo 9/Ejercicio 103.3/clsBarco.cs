using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio103._3
{
    internal class clsBarco : clsVehiculo
    {
        public override void Desplazarse()
        {
            Console.WriteLine("Accion de desplazar para barco.");
        }

        public override void Detenerse()
        {
            Console.WriteLine("El barco se detiene en el agua.");
        }
    }
}
