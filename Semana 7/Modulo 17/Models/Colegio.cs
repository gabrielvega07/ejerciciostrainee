using System.Collections;
using System.Collections.Generic;

namespace Ejercicio182.Models
{
    public class Colegio
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public ICollection<Clase> Clases { get; set; }  
    }
}
