namespace RestaurantSimulator.Model;

public abstract class MenuItem
{
    public string Name { get; init; }
    public int Price { get; init; }

    public MenuItem(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} Price: {Price} Huf";
    }
}