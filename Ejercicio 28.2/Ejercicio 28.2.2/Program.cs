using System;

namespace Ejercicio_.Net_Core_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Name = "Pablo";
            Version dotnetVersion = Environment.Version;

            Console.WriteLine($"Hola {Name} este es un proyecto de .Net Core en su Version {dotnetVersion}");
            Console.ReadKey();
        }
    }
}
