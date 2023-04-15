using RestaurantSimulator.Model.Enums;

namespace RestaurantSimulator.Model;

public record Ingredient(IngredientEnum IngredientName)
{
    public override string ToString()
    {
        return IngredientName.ToString();
    }
};
