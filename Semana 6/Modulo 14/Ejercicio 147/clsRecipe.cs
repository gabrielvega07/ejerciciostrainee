using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio147
{
    internal class clsRecipe
    {
        public string Name { get; }
        public string[] Ingredients { get; }

        public clsRecipe(string name)
        {
            Name = name;
            Ingredients = new string[] { "patatas", "huevos", "cebolla", "aceite", "sal" };
        }

        public async Task PrepareRecipeAsync()
        {
            await PrepareIngredientsAsync();
            await CookAsync();
        }

        private async Task PrepareIngredientsAsync()
        {
            Console.WriteLine("Pelando y cortando las patatas...");
            await Task.Delay(1000);

            Console.WriteLine("Cortando la cebolla...");
            await Task.Delay(500);

            Console.WriteLine("Batiendo los huevos...");
            await Task.Delay(300);
        }

        private async Task CookAsync()
        {
            Console.WriteLine("Calentando el aceite en la sartén...");
            await Task.Delay(1000);

            Console.WriteLine("Añadiendo las patatas y la cebolla a la sartén...");
            await Task.Delay(1500);

            Console.WriteLine("Cocinando la tortilla por ambos lados...");
            await Task.Delay(2000);
        }

    }
}
