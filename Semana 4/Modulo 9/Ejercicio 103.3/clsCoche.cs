using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio103._3
{
    internal class clsCoche : clsVehiculo
    {
        public override void Desplazarse()
        {
            Console.WriteLine("Accion de desplazar para coche.");
        }

        public override void Detenerse()
        {
            Console.WriteLine("El coche se detiene en la calle.");
        }
    }
}
