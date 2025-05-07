using CookBookSolution.Recipes;
using CookBookSolution.Recipes.Ingredients;

namespace CookBookSolution.App;

public interface IRecipesConsoleUserInteraction
{
    void ShowMessage(string message);

    void Exit();

    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);

    void PromptToCreateRecipe();
    IEnumerable<Ingredient> ReadIngredientsFromUser();
}
