using Microsoft.EntityFrameworkCore;

namespace Ejercicio182.Models
{
    public class DBContexto : DbContext
    {
        public DBContexto(DbContextOptions<DBContexto> options) : base(options) { }

        public DbSet<Colegio> Colegios { get; set; }
        public DbSet<Clase> Clases { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuraciones del modelo...
        }

        public void InitializeData()
        {
            // Inserta datos de ejemplo aquí
            var colegio1 = new Colegio { Nombre = "Colegio 1" };
            var colegio2 = new Colegio { Nombre = "Colegio 2" };
            var clase1 = new Clase { Nombre = "Clase 1", ColegioId = 1 };
            var clase2 = new Clase { Nombre = "Clase 2", ColegioId = 2 };
            var profesor1 = new Profesor { Nombre = "Profesor 1", ClaseId = 1 };
            var profesor2 = new Profesor { Nombre = "Profesor 2", ClaseId = 2 };
            var alumno1 = new Alumno { Nombre = "Alumno 1", ClaseId = 1 };
            var alumno2 = new Alumno { Nombre = "Alumno 2", ClaseId = 2 };

            Colegios.AddRange(colegio1, colegio2);
            Clases.AddRange(clase1, clase2);
            Profesores.AddRange(profesor1, profesor2);
            Alumnos.AddRange(alumno1, alumno2);

            SaveChanges();
        }
    }
}
