using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio103._5
{
    public static class clsProducto
    {
        public static int Sumar(double precio, double impuesto)
        {
            impuesto =  precio * 0.12;
            return (int)(precio + impuesto);
        }
    }
}
