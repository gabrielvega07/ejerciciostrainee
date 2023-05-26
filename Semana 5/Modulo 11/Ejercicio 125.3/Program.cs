// See https://aka.ms/new-console-template for more information

using Ejercicio125._3;

Dictionary<int, clsAnimal> animales = new Dictionary<int, clsAnimal>
{
    { (int)Animales.Perro, new clsAnimal(Animales.Perro)},
    { (int)Animales.Gato, new clsAnimal(Animales.Gato)},
    { (int)Animales.Canario, new clsAnimal(Animales.Canario)},
    { (int)Animales.Caballo, new clsAnimal(Animales.Caballo)},
};

Console.WriteLine("Ingresa un numero: ");

int numero =  int.Parse(Console.ReadLine());    

VerificarAnimal(animales, numero);

Console.ReadLine();

static void VerificarAnimal(Dictionary<int, clsAnimal> animales, int numero)
{
    if (animales.ContainsKey(numero))
    {
        clsAnimal animal = animales[numero];
        string nombreAnimal = Enum.GetName(typeof(Animales), (int)animal.TipoAnimal);
        Console.WriteLine("Ese valor pertenece al {0}", nombreAnimal);
    }

    else 
    {
        Console.WriteLine("El numero ingresado no pertenece a ningun animal.");
    }
}

