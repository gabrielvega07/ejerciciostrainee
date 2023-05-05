// See https://aka.ms/new-console-template for more information

Console.Write("Ingresar una letra: ");
char letra = Console.ReadKey().KeyChar;

if (EsNumero(letra))
{
    Console.WriteLine("\n El valor ingresado es un número.");
}
else if (EsVocal(letra))
{
    Console.WriteLine("\n La letra ingresada es una vocal.");
}
else if (EsConsonante(letra))
{
    Console.WriteLine("\n La letra ingresada es una consonante.");
}
else
{
    Console.WriteLine("\n No es una letra válida.");
}

Console.ReadKey();


static bool EsNumero(char letra)
{
    return Char.IsDigit(letra); //Char.IsDigit para determinar si el carácter introducido es un número
}

static bool EsVocal(char letra)
{
    letra = Char.ToLower(letra);
    return letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u';
}

static bool EsConsonante(char letra)
{
    letra = Char.ToLower(letra);
    return Char.IsLetter(letra) && !EsVocal(letra);
}