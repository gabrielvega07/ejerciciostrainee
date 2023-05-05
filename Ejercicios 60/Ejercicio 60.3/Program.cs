// See https://aka.ms/new-console-template for more information


Console.Write("Ingrese un importe en quetzales: ");
double importe = Convert.ToDouble(Console.ReadLine());

DesglosarBilletes(importe);
DesglosarMonedas(importe);
 

static void DesglosarBilletes(double importe)
{
    Console.WriteLine("Billetes:");

    int[] valorBilletes = { 200, 100, 50, 20, 10, 5, 1 };
    int[] cantidadBilletes = new int[valorBilletes.Length];

    int quetzales = (int)importe;

    for (int i = 0; i < valorBilletes.Length; i++)
    {
        cantidadBilletes[i] = quetzales / valorBilletes[i];
        quetzales %= valorBilletes[i];

        if (cantidadBilletes[i] > 0)
        {
            Console.WriteLine($"  {cantidadBilletes[i]} billetes de Q.{valorBilletes[i]}");
        }
    }
}

static void DesglosarMonedas(double importe)
{
    Console.WriteLine("Monedas:");

    int[] valoresCentavos = { 50, 25, 10, 5, 1 };
    int[] cantidadMonedas = new int[valoresCentavos.Length];

    int centavos = (int)((importe - (int)importe) * 100);

    for (int i = 0; i < valoresCentavos.Length; i++)
    {
        cantidadMonedas[i] = centavos / valoresCentavos[i];
        centavos %= valoresCentavos[i];

        if (cantidadMonedas[i] > 0)
        {
            Console.WriteLine($"  {cantidadMonedas[i]} monedas de {valoresCentavos[i]} centavos");
        }
    }

}