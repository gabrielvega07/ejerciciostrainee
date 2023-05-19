using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio103._3
{
    public class clsVehiculo
    {
        public virtual void Desplazarse()
        {
            Console.WriteLine("Accion de desplazarse");
        }

        public virtual void Detenerse() 
        {
            Console.WriteLine("Accion de detenerse");
        }
    }
}
