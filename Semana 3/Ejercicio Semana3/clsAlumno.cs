using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSemana3
{
    internal class clsAlumno
    {
        public string Nombre {  get; set; }
        public string Apellido { get; set; }
        public int NumeroIdentificacion { get; set; }
        public string Carrera { get; set; }
        public List<double> Notas { get; set;}

        public clsAlumno(string nombre, string apellido, int numeroIdentificacion,  string carrera, List<double> notas)
        {
            Nombre = nombre;
            Apellido = apellido;
            NumeroIdentificacion = numeroIdentificacion;
            Carrera = carrera;
            Notas = notas;
        }

        public double CalcularPromedio()
        {
            double sumarNotas = 0;
            foreach (var nota in Notas)
            {
                sumarNotas += nota;
            }
            return sumarNotas / Notas.Count;
        }
    }
}
