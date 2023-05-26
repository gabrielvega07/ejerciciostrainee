// See https://aka.ms/new-console-template for more information

using EjercicioSemana4;


// Crear instancia de la biblioteca
clsBiblioteca biblioteca = new clsBiblioteca();

// Crear instancias de libros y revistas
clsLibro libro1 = new clsLibro("El Gran Gatsby", "F. Scott Fitzgerald");
clsLibro libro2 = new clsLibro("Cien años de soledad", "Gabriel García Márquez");
clsRevista revista1 = new clsRevista("National Geographic", 123);
clsRevista revista2 = new clsRevista("Time", 456);

// Agregar materiales a la biblioteca
biblioteca.AgregarMaterial(libro1);
biblioteca.AgregarMaterial(libro2);
biblioteca.AgregarMaterial(revista1);
biblioteca.AgregarMaterial(revista2);

// Búsqueda por título
string tituloBusqueda = "Gatsby";
List<clsMaterial> resultadosBusqueda = biblioteca.BuscarPorTitulo(tituloBusqueda);
Console.WriteLine("Resultados de la búsqueda por título '{0}':", tituloBusqueda);
if (resultadosBusqueda.Count > 0)
{
    foreach (clsMaterial material in resultadosBusqueda)
    {
        Console.WriteLine("- {0}", material.Titulo);
    }
}
else
{
    Console.WriteLine("No se encontraron resultados.");
}

Console.WriteLine();

// Préstamo de material
biblioteca.PrestarMaterial(libro1);
biblioteca.PrestarMaterial(revista1);
biblioteca.PrestarMaterial(libro2);

Console.WriteLine();

// Devolución de material
biblioteca.DevolverMaterial(libro1);
biblioteca.DevolverMaterial(revista1);
biblioteca.DevolverMaterial(libro2);

Console.ReadLine();

