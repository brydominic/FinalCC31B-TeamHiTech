using System.Collections.Generic;
using System.Linq;
using Engine.Models;
namespace Engine.Factories
{
    public static class RecipeFactory
    {
        private static readonly List<Recipe> _recipes = new List<Recipe>();
        static RecipeFactory()
        {
            Recipe potion = new Recipe(1, "Potion");
            potion.AddIngredient(3001, 1);
            potion.AddIngredient(3002, 1);
            potion.AddIngredient(3003, 1);
            potion.AddOutputItem(2001, 1);
            _recipes.Add(potion);
        }
        public static Recipe RecipeByID(int id)
        {
            return _recipes.FirstOrDefault(x => x.ID == id);
        }
    }
}