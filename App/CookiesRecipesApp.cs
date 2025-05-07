using CookBookSolution.Recipes;

namespace CookBookSolution.App;

public class CookiesRecipesApp
{
    private readonly IRecipesRepository _recipesRepository;
    private readonly IRecipesConsoleUserInteraction _RecipesConsoleUserInteraction;

    public CookiesRecipesApp(
        IRecipesRepository recipesRepository,
        IRecipesConsoleUserInteraction RecipesConsoleUserInteraction)
    {
        _recipesRepository = recipesRepository;
        _RecipesConsoleUserInteraction = RecipesConsoleUserInteraction;
    }

    public void Run(string filePath)
    {
        var allRecipes = _recipesRepository.Read(filePath);
        _RecipesConsoleUserInteraction.PrintExistingRecipes(allRecipes);

        _RecipesConsoleUserInteraction.PromptToCreateRecipe();

        var ingredients = _RecipesConsoleUserInteraction.ReadIngredientsFromUser();

        if (ingredients.Count() > 0)
        {
            var recipes = new Recipe(ingredients);
            allRecipes.Add(recipes);
            _recipesRepository.Write(filePath, allRecipes);

            _RecipesConsoleUserInteraction.ShowMessage("Recipe added:");
            _RecipesConsoleUserInteraction.ShowMessage(recipes.ToString());
        }
        else
        {
            _RecipesConsoleUserInteraction.ShowMessage(
                "No ingredients have been selected. " +
                "Recipe will not be saved."
            );
        }

        _RecipesConsoleUserInteraction.Exit();
        
    }
}
