// See https://aka.ms/new-console-template for more information


Console.WriteLine("Ingresar una cadena: ");
string cadena = Console.ReadLine();
if (EsPalindromo(cadena))
{
    Console.WriteLine($"{cadena} Si es palíndromo");
}
else
{
    Console.WriteLine($"{cadena} No es palíndromo");
}

static bool EsPalindromo(string cadena)
{
    // Eliminar espacios en blanco y convertir a minúsculas para comparar 
    cadena = cadena.Replace(" ", "").ToLower();
    // Comparar la cadena original con la cadena invertida
    return cadena == new string(cadena.Reverse().ToArray());
}

Console.ReadKey();
