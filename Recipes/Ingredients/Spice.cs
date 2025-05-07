namespace CookBookSolution.Recipes.Ingredients;

public abstract class Spice: Ingredient
{
    public override string PrepareInstructions => $"Take half a teaspoon. {base.PrepareInstructions}";
}
