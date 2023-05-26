// See https://aka.ms/new-console-template for more information

using System.Globalization;

Dictionary<int, string> diccionario = new Dictionary<int, string>();

while (true)

{
    Console.WriteLine("Introducir un nomero para clave: ");
    int clave = Convert.ToInt32(Console.ReadLine());

    if (clave == 0)
    { break; }

    Console.WriteLine("Introducir una cadena: ");
    string cadena = Console.ReadLine();

    diccionario[clave] = cadena;
}


Console.WriteLine("Introduce una cadena de 2 letras: ");
string letras = Console.ReadLine();

Console.WriteLine("Claves que contiene los caracteres '{0}'", letras);

foreach (KeyValuePair<int, string> kvp in diccionario)
{
    if (kvp.Value.Contains(letras))
        Console.WriteLine(kvp.Key);
}

Console.ReadLine();

