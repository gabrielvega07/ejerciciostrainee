using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_28._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            var Saludo = "Hola";

            Console.WriteLine("Ingrese su nombre:");
            Nombre = Console.ReadLine();
            Console.WriteLine(Saludo + ", " + Nombre);
            Console.ReadKey();
        }
    }
}
