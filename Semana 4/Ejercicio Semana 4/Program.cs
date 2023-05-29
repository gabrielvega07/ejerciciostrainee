// See https://aka.ms/new-console-template for more information

using RetoSemanal4;
clsBiblioteca biblioteca = new clsBiblioteca();

// Crear instancias de Libro y Revista
Libro libro1 = new Libro("Cien años de soledad", "Gabriel García Márquez");
Libro libro2 = new Libro("1984", "George Orwell");
Libro libro3 = new Libro("Cien años", "Gabriel García Márquez");
Revista revista1 = new Revista("National Geographic", "Mayo 2023");
Revista revista2 = new Revista("National Geographic", "Mayo 2022");

// Agregar materiales a la biblioteca
biblioteca.AgregarMaterial(libro1);
biblioteca.AgregarMaterial(libro2);
biblioteca.AgregarMaterial(libro3);
biblioteca.AgregarMaterial(revista1);
biblioteca.AgregarMaterial(revista2);

// Búsqueda por título
Console.WriteLine("Búsqueda por título: 'cien'");
List<clsMaterial> resultados = biblioteca.BuscarPorTitulo("cien");
if (resultados.Count > 0)
{
    Console.WriteLine("Resultados de la búsqueda:");
    for (int i = 0; i < resultados.Count; i++)
    {
        Console.WriteLine("{0}. {1} ({2})", i + 1, resultados[i].Titulo, resultados[i].GetType().Name);
    }

    Console.WriteLine("Ingrese el número del material que desea prestar:");
    int seleccion = int.Parse(Console.ReadLine());

    if (seleccion > 0 && seleccion <= resultados.Count)
    {
        clsMaterial materialSeleccionado = resultados[seleccion - 1];
        biblioteca.PrestarMaterial(materialSeleccionado);
    }
    else
    {
        Console.WriteLine("Selección inválida.");
    }
}
else
{
    Console.WriteLine("No se encontraron materiales con ese título.");
}

Console.ReadLine();