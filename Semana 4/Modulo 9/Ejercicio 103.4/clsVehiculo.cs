using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio103._4
{
    public class clsVehiculo
    {
        private int ruedas, puertas;
        public clsVehiculo()
        {
            ruedas = 0;
            puertas = 0;
        }

        public clsVehiculo(int ruedas, int puertas)
        {
            this.ruedas = ruedas;   
            this.puertas = puertas; 

        }

        public clsVehiculo(int ruedas)
        {
            this.ruedas = ruedas;
            puertas = 0;
        }

        public int Ruedas
        {
            get { return ruedas; }
            set { ruedas = value; }
        }

        public int Puertas
        {
            get { return puertas; }
            set { puertas = value; }
        }
    }
}
