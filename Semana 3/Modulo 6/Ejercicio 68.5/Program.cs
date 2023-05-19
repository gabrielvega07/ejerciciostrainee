// See https://aka.ms/new-console-template for more information
using System;

char[] letras = new char['Z' - 'A' + 1];

for (int i = 0, letra = 'Z'; i < letras.Length; i++, letra--)
{
    letras[i] = (char)letra;
}

string cadena = String.Join(" ", letras);

Console.WriteLine($"La cadena de las letras de la Z a la A es: \n{cadena}");
   

Console.ReadKey();