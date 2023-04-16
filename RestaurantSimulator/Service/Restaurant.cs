using RestaurantSimulator.Model;
using RestaurantSimulator.Model.Enums;
using RestaurantSimulator.Model.MenuProvider;
using RestaurantSimulator.Model.ServeAble;

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

    public void Test(IngredientEnum ingredientEnum)
    {
        switch (ingredientEnum)
        {
            case IngredientEnum.TomatoSauce:
            case IngredientEnum.MozzarellaCheese:
            case IngredientEnum.FreshBasil:
            case IngredientEnum.Pepperoni:
            case IngredientEnum.Ham:
            case IngredientEnum.Pineapple:
                break;
            case IngredientEnum.Sausage:
                break;
            case IngredientEnum.Bacon:
                break;
            case IngredientEnum.GroundBeef:
                break;
            case IngredientEnum.Mushrooms:
                break;
            case IngredientEnum.GreenPepper:
                break;
            case IngredientEnum.Onion:
                break;
            case IngredientEnum.Olive:
                break;
            case IngredientEnum.RomaineLettuce:
                break;
            case IngredientEnum.Crouton:
                break;
            case IngredientEnum.ParmesanCheese:
                break;
            case IngredientEnum.CaesarDressing:
                break;
            case IngredientEnum.SlicedTomatoes:
                break;
            case IngredientEnum.BalsamicGlaze:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(ingredientEnum), ingredientEnum, null);
        }
    }
}