// See https://aka.ms/new-console-template for more information

using Ejercicio125._2;

clsListado<string> lista = new clsListado<string>();

while (true)
{
    Console.WriteLine("Introducir un valor o salir para mostrar listado");
    string valor = Console.ReadLine();
    if (valor.ToLower() == "salir")
        break;
    lista.AgrgarValor(valor);
}

lista.MostrarLista();

Console.ReadKey();
