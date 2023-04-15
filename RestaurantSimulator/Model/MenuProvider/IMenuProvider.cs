using RestaurantSimulator.Model.PrepareAble;
using RestaurantSimulator.Model.PrepareAble;

namespace RestaurantSimulator.Model.MenuProvider;

public interface IMenuProvider
{
    public List<Pizza> Pizzas { get; init; }
    public List<Salad> Salads { get; init; }
    public List<MenuItem> Drinks { get; init; }

}