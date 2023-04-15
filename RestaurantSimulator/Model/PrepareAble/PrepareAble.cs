namespace RestaurantSimulator.Model.PrepareAble;

public abstract class PrepareAble : MenuItem
{
    public List<Ingredient> Ingredients;

    public PrepareAble(string name, int price, List<Ingredient> ingredients) : base(name, price)
    {
        Ingredients = ingredients;
    }
}