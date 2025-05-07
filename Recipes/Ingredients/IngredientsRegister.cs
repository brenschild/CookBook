namespace CookBookSolution.Recipes.Ingredients;

public class IngredientsRegister : IIngredientsRegister
{
    public IEnumerable<Ingredient> All { get; } = new List<Ingredient>
{
    new WheatFlour(),
    new Butter(),
    new Sugar(),
    new CocoaPowder(),
    new Cinnamon(),
    new CoconutFlour(),
    new Cardamom(),
    new Chocolate()
}.OrderBy(x => x.Id);

    public Ingredient? GetById(int id)
    {
        foreach (var ingredient in All)
        {
            if (ingredient.Id == id) return ingredient;
        }
        return null;
    }
}
