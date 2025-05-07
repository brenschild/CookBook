using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBookSolution.Recipes.Ingredients;

public abstract class Flour : Ingredient
{
    public override string PrepareInstructions => $"Sieve. {base.PrepareInstructions}";
}
