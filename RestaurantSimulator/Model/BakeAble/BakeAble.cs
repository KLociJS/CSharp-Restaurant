namespace RestaurantSimulator.Model.BakeAble;

public abstract class BakeAble : MenuItem
{
    public List<Ingredient> Ingredients;

    public BakeAble(string name, int price, List<Ingredient> ingredients) : base(name, price)
    {
        Ingredients = ingredients;
    }
}