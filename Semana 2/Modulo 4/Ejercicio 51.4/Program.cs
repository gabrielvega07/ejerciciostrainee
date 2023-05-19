// See https://aka.ms/new-console-template for more information


Console.WriteLine("Ingrese el precio del producto");
double precio = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la forma de pago que desea utilizar: ");
string formaDePago = Console.ReadLine();

if (formaDePago.ToLower() == "efectivo")
{
    Console.WriteLine("El precio a pagar en efectivo es de: " + precio);
}

else if (formaDePago.ToLower() == "tarjeta")
{
    Console.WriteLine("Ingrese el numero de la cuenta: ");
    string numeroCuenta = Console.ReadLine();
    Console.WriteLine("El precio a debitar de su cuenta es de " + precio);
}
else
{
    Console.WriteLine("La forma de pago no es valida");
}

Console.ReadKey();

