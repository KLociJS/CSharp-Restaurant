

using System.Collections;

namespace RestaurantSimulator.Model.PrepareAble;

public class Pizza : MenuItem, IPrepareAble
{
    public List<Ingredient> Ingredients { get; init; }
    public Pizza(string name, int price, List<Ingredient> ingredients) : base(name, price)
    {
        Ingredients = ingredients;
    }
    public override string ToString()
    {
        var ingredientString = string.Join(", ", Ingredients.Select(i=>i.ToString()));
        return $"{Name}, Price: {Price}, Ingredients: {ingredientString}";
    }
    
}