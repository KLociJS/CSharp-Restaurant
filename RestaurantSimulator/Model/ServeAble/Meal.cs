namespace RestaurantSimulator.Model.ServeAble;

public class Meal : MenuItem, IServeAble
{
    public Meal(string name, int price) : base(name, price)
    {
    }
}