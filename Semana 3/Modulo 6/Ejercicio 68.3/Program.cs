// See https://aka.ms/new-console-template for more information
//using System.Globalization;  esta libreria fue agregada por un error de escritura ('StringInfo' en lugar de 'string') debido a las propidedades de .Net6 
using System.Text;


Console.WriteLine("Ingrese una frase qeu contenga al menos 20 caracteres y 4 palabras: ");
string frase = Console.ReadLine();

if (frase.Length < 20 || frase.Split(' ').Length < 4)
{
    Console.WriteLine("La frase no cumple con los requisitos: ");
    return;
}

//metodos 
static string ConversionMayusculas(string cadena)
{
    return cadena.ToUpper();
}

static string ConversionMinusculas(string cadena)
{
    return cadena.ToLower();
}

static string EliminarPrimeras3Letras(string cadena)
{
    return cadena.Substring(3);
}

static string ExtraerLetras(string cadena, int inicio, int fin)
{
    return cadena.Substring(inicio - 1, fin - inicio + 1);
}

static string InvertirFrase(string cadena)
{
    char[] cadenaArray = cadena.ToCharArray();
    Array.Reverse(cadenaArray);
    return new string (cadenaArray);
}

static int ContarPalabras(string cadena)
{
    return cadena.Split(' ').Length;
}

static string ObtenerTercerPalabra(string cadena)
{
    string[] palabas = cadena.Split(' ');
    if (palabas.Length >= 3)
    {
        return palabas[2];
    }

    else
    {
        return "La cadena no tiene suficientes palabras";
    }
}

Console.WriteLine("Cadena en mayúsculas: " + ConversionMayusculas(frase));
Console.WriteLine("Cadena en minúsculas: " + ConversionMinusculas(frase));
Console.WriteLine("Cadena sin las 3 primeras letras: " + EliminarPrimeras3Letras(frase));
Console.WriteLine("Cadena con las letras de la posición 5 a la 10: " + ExtraerLetras(frase, 5, 10));
Console.WriteLine("Cadena invertida: " + InvertirFrase(frase));
Console.WriteLine("Número de palabras: " + ContarPalabras(frase));
Console.WriteLine("Tercera palabra: " + ObtenerTercerPalabra(frase));

Console.ReadLine();




