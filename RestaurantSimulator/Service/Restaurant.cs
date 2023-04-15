using RestaurantSimulator.Model.MenuProvider;

namespace RestaurantSimulator.Service;

public class Restaurant
{
    private readonly IMenuProvider _menuProvider;
    
    public Restaurant(IMenuProvider menuProvider)
    {
        _menuProvider = menuProvider;
    }

    public void TakeMenu()
    {
        var drinks = _menuProvider.Drinks;
        var pizzas = _menuProvider.Pizzas;
        var salads = _menuProvider.Salads;

        Console.WriteLine("Drinks: ");
        foreach (var drink in drinks)
        {
            Console.WriteLine(drink);
        }

        Console.WriteLine("Meals: ");
        foreach (var pizza in pizzas)
        {
            Console.WriteLine(pizza);
        }

        Console.WriteLine("Salads: ");
        foreach (var salad in salads)
        {
            Console.WriteLine(salad);
        }
    }
}