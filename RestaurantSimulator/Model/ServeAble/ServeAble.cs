namespace RestaurantSimulator.Model.ServeAble;

public abstract class ServeAble : MenuItem
{
    public ServeAble(string name, int price) : base(name, price)
    {
    }
}