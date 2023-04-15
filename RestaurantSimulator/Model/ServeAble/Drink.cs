namespace RestaurantSimulator.Model.ServeAble;

public class Drink : MenuItem, IServeAble
{
    public Drink(string name, int price) : base(name, price)
    {
    }

    public override string ToString()
    {
        return $"{Name}, Price: {Price}";
    }
}