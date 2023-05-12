// See https://aka.ms/new-console-template for more information


List<string> nombres = new List<string>();

for  (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Ingrese un nombre: ");
    string nombre = Console.ReadLine();
    nombres.Add(nombre);
}

Console.WriteLine("Ingrese el nombre que desea buscar: ");
string nombreBuscado = Console.ReadLine();  

if (nombres.Contains(nombreBuscado))
{
    Console.WriteLine($"El nombre {nombreBuscado} si se encuentra en la lista");
}
else
{
    Console.WriteLine($"El nombre {nombreBuscado} no se encuentra en la lista");
}

Console.ReadLine();

