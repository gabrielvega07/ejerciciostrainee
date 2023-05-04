// See https://aka.ms/new-console-template for more information

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0 || i % 3 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.ReadKey();