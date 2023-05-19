using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio103._3
{
    internal class clsAvion : clsVehiculo
    {
        public override void Desplazarse()
        {
            Console.WriteLine("Accion de desplazar para avion.");
        }

        public override void Detenerse()
        {
            Console.WriteLine("El avion se detiene en pista.");
        }
    }
}
