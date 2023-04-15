using RestaurantSimulator.Model.ServeAble;
namespace RestaurantSimulator.Model.StockProvider;

public interface IStockProvider
{
    public Dictionary<Ingredient,int> Ingredients { get; set; }
    public Dictionary<Drink,int> Drinks { get; set; }
}