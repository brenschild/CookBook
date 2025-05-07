using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookBookSolution.Recipes.Ingredients;

namespace CookBookSolution.Recipes;

 public class Recipe
{
    public IEnumerable<Ingredient> Ingredients { get; }
    
    public Recipe(IEnumerable<Ingredient> ingredients)
    {
        Ingredients = ingredients;
    }

    public override string ToString()
    {
        var steps = new List<string>();
        foreach(var ingredient in Ingredients)
        {
            steps.Add($"{ingredient.Name}. {ingredient.PrepareInstructions}");
        }

        return string.Join(Environment.NewLine, steps);
    }
}
