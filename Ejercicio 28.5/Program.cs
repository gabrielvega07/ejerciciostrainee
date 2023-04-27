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
            string Name;
            string City; 
            var Greet = "Hola";
            var Welcome = "bienvenido a"; 

            Console.WriteLine("Ingrese su nombre:");
            Name = Console.ReadLine();
            Console.WriteLine("Ingrese una ciudad:");
            City = Console.ReadLine();
            Console.WriteLine($"{Greet} {Name}, {Welcome} {City}, espero quue disfrutes tu estancia.");
            Console.ReadKey();
        }
    }
}



 