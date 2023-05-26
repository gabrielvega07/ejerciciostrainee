using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio139
{
    public class clsPersona
    {
        public string Nombre { get; set; }  
        public int Edad { get; set; }
        public string Localidad { get; set; }


        public clsPersona (string nombre, int edad, string localidad)
        {
            Nombre = nombre;    
            Edad = edad;    
            Localidad = localidad;  
        }

        public string ObtenerCadenaPersona()
        {
            return $"{Nombre}|{Edad}|{Localidad}";
        }
    }

}
