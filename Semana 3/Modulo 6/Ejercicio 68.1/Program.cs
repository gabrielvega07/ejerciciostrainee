// See https://aka.ms/new-console-template for more information


Console.WriteLine("Ingrese su nombre: ");
string nombre = Console.ReadLine();

if (nombre.ToLower() == "alejandro")
{
    Console.WriteLine("Hola Alejandro");
}

else
{
    Console.WriteLine("No te conozco");
}

Console.ReadKey();
