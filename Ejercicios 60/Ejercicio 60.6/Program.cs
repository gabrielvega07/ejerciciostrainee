// See https://aka.ms/new-console-template for more information

int numero, maximo = int.MinValue, minimo = int.MaxValue, cantidad = 0;
do
{
    Console.Write("Ingrese un numero, (solo uno le permite salir del programa): ");
    numero = int.Parse(Console.ReadLine());

    if (numero != 0)
    {
        maximo = CalcularMaximo(maximo, numero);
        minimo = CalcularMinimo(minimo, numero);
        cantidad++;
    }
} while (numero != 0);

if (cantidad > 0)
{
    int diferencia = maximo - minimo;
    Console.WriteLine($"Número más alto: {maximo}");
    Console.WriteLine($"Número más bajo: {minimo}");
    Console.WriteLine($"Diferencia entre el mayor y el menor es de: {diferencia}");
    Console.WriteLine($"Cantidad de números introducidos fue de: {cantidad}");
}
else
{
    Console.WriteLine("No se ingresó ningún número diferente a 0.");
}

static int CalcularMaximo(int numero1, int numero2)
{
    if (numero1 >= numero2)
    {
        return numero1;
    }
    else
    {
        return numero2;
    }
}

static int CalcularMinimo(int numero1, int numero2)
{
    if (numero1 <= numero2)
    {
        return numero1;
    }
    else
    {
        return numero2;
    }
}

Console.ReadKey();
