// See https://aka.ms/new-console-template for more information


using EjercicioSemana3;
//using System.ComponentModel;

List<clsAlumno> listaAlumnos = new List<clsAlumno>();

listaAlumnos.Add(new clsAlumno("Juan", "Perez", 001, "Ingenieria", new List<double> { 5, 5, 5, 5, 5 }));
listaAlumnos.Add(new clsAlumno("María", "González", 002, "Medicina", new List<double> { 9, 9, 9, 9, 9 }));
listaAlumnos.Add(new clsAlumno("Carlos", "López", 003, "Arquitectura", new List<double> { 7, 7, 7, 7, 7 }));
listaAlumnos.Add(new clsAlumno("Laura", "Rodríguez", 004, "Derecho", new List<double> { 6, 5, 7, 6, 6 }));
listaAlumnos.Add(new clsAlumno("Luis", "Martínez", 005, "Economía", new List<double> { 8, 7, 6, 8, 9 }));

Console.WriteLine("Lista completa de estudiantes: ");

foreach(clsAlumno alumno in listaAlumnos)
{
    double promedio = alumno.CalcularPromedio();
    Console.WriteLine("Nombre completo: {0} {1}", alumno.Nombre, alumno.Apellido);
    Console.WriteLine("Numero de Identificacion: {0}", alumno.NumeroIdentificacion);
    Console.WriteLine("Carrera: {0}", alumno.Carrera);
    Console.WriteLine("Promedio del alumno: {0}\n", promedio);
}

Console.WriteLine("Estudiantes con promedio igual o mayor a 6: ");
foreach (clsAlumno alumno in listaAlumnos)
{
    double promedio = alumno.CalcularPromedio();
    if (promedio >= 6)
    {
        Console.WriteLine("Nombre completo: {0} {1}", alumno.Nombre, alumno.Apellido);
        Console.WriteLine("Numero de Identificacion: {0}\n", alumno.NumeroIdentificacion);
    }
}


Console.ReadLine();


