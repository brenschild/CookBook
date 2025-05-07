namespace CookBookSolution.Recipes.Ingredients;

public abstract class Flour : Ingredient
{
    public override string PrepareInstructions => $"Sieve. {base.PrepareInstructions}";
}
