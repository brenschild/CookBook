﻿namespace CookBookSolution.Recipes.Ingredients;

public abstract class Ingredient
{
    public abstract int Id { get; }
    public abstract string Name { get; }
    public virtual string PrepareInstructions => "Add to other ingredients.";

    public override string ToString()
    {
        return $"{Id}. {Name}";
    }
}
