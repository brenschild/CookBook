using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookBookSolution.Recipes;

namespace CookBookSolution.Recipes.Ingredients;

public abstract class Spice: Ingredient
{
    public override string PrepareInstructions => $"Take half a teaspoon. {base.PrepareInstructions}";
}
