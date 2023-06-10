using System.Collections;
using System.Collections.Generic;

namespace Ejercicio182.Models
{
    public class Clase
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public int ColegioId { get; set; }
        public Colegio Colegio { get; set;}
        public ICollection<Alumno> Alumno { get; set; }
        public ICollection<Profesor> Profesor { get; set;
        }
    }
}
