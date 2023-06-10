namespace Ejercicio182.Models
{
    public class Profesor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int ClaseId { get; set; }
        public Clase Clase { get; set; }
    }
}
