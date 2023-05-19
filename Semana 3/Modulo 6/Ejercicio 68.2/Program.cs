// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingrese una palabra: ");
string palabra = Console.ReadLine();

//convertir la palabra en un arreglo de carcteres
char[] caracteresEvaluados = palabra.ToCharArray();

//revertir el arreglo de caracteres para formar la nueva palabra   
Array.Reverse(caracteresEvaluados);                  


string palabraInvertida = new string(caracteresEvaluados);
Console.WriteLine($"La palabra invertida es: " + palabraInvertida);

Console.ReadKey();
