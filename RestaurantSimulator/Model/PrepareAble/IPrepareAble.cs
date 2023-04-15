namespace RestaurantSimulator.Model.PrepareAble;

public interface IPrepareAble
{
    public string Name { get; init; }
    public int Price { get; init; }
    public List<Ingredient> Ingredients { get; init; }
}