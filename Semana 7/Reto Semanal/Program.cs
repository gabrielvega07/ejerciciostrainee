// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using ObtnerChiste;
//instalar Install-Package Newtonsoft.Json


string filePath = "chistes.txt";
ChuckNorrisChistes chuckNorrisJokes = new ChuckNorrisChistes(filePath);
chuckNorrisJokes.Run();

Console.ReadLine();