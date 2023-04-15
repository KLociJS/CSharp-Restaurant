namespace RestaurantSimulator.Model.MenuProvider;

public interface IMenuProvider
{
    public List<MenuItem> Meals { get; init; }
    public List<MenuItem> Drinks { get; init; }

}