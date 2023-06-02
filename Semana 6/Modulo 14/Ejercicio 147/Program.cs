// See https://aka.ms/new-console-template for more information

using Ejercicio147;

clsRecipe tortillaRecipe = new clsRecipe("Tortilla de Patatas");

Console.WriteLine($"Receta: {tortillaRecipe.Name}");
Console.WriteLine("Ingredientes:");
foreach (var ingredient in tortillaRecipe.Ingredients)
{
    Console.WriteLine($"- {ingredient}");
}

Console.WriteLine("Preparando la receta...");
await tortillaRecipe.PrepareRecipeAsync();

Console.WriteLine("¡La tortilla de patatas está lista!");

Console.ReadLine();



