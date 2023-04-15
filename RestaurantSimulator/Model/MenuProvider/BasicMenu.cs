using RestaurantSimulator.Model.ServeAble;
using RestaurantSimulator.Model.BakeAble;
using RestaurantSimulator.Model.Enums;
using RestaurantSimulator.Model.PrepareAble;

namespace RestaurantSimulator.Model.MenuProvider;

public class BasicMenu : IMenuProvider
{
    public List<MenuItem> Meals { get; init; }
    public List<MenuItem> Drinks { get; init; }

    public BasicMenu()
    {
        Meals = GenerateMeals();
        Drinks = GenerateDrinks();
    }

    private List<MenuItem> GenerateDrinks()
    {
        var menu = new List<MenuItem>()
        {
            new Drink("Coca-cola", 600),
            new Drink("Light Coca-cola", 600),
            new Drink("Zero Coca-cola", 600),
            new Drink("Sprite", 600),
            new Drink("Water", 400),
            new Drink("Soda", 400)
        };
        
        return menu;
    }
    
    private List<MenuItem> GenerateMeals()
    {
        var menu = new List<MenuItem>()
        {
            new Pizza("Margherita Pizza", 3600, new List<Ingredient>()
            {
                new Ingredient(IngredientEnum.TomatoSauce),
                new Ingredient(IngredientEnum.MozzarellaCheese),
                new Ingredient(IngredientEnum.FreshBasil)
            }),
            new Pizza("Pepperoni Pizza", 3600, new List<Ingredient>()
            {
                new Ingredient(IngredientEnum.TomatoSauce),
                new Ingredient(IngredientEnum.MozzarellaCheese),
                new Ingredient(IngredientEnum.Pepperoni)
            }),
            new Pizza("Hawaiian Pizza", 3600, new List<Ingredient>()
            {
                new Ingredient(IngredientEnum.TomatoSauce),
                new Ingredient(IngredientEnum.MozzarellaCheese),
                new Ingredient(IngredientEnum.Ham),
                new Ingredient(IngredientEnum.Pineapple)
            }),
            new Pizza("Meat Lovers Pizza", 3600, new List<Ingredient>()
            {
                new Ingredient(IngredientEnum.TomatoSauce),
                new Ingredient(IngredientEnum.MozzarellaCheese),
                new Ingredient(IngredientEnum.Pepperoni),
                new Ingredient(IngredientEnum.Sausage),
                new Ingredient(IngredientEnum.Bacon),
                new Ingredient(IngredientEnum.GroundBeef)
            }),
            new Pizza("Veggie Pizza", 5600, new List<Ingredient>()
            {
                new Ingredient(IngredientEnum.TomatoSauce),
                new Ingredient(IngredientEnum.MozzarellaCheese),
                new Ingredient(IngredientEnum.Mushrooms),
                new Ingredient(IngredientEnum.GreenPepper),
                new Ingredient(IngredientEnum.Onion),
                new Ingredient(IngredientEnum.Olive)
            }),
            new Salad("Caesar Salad", 2000,new List<Ingredient>()
            {
                new Ingredient(IngredientEnum.RomaineLettuce),
                new Ingredient(IngredientEnum.Crouton),
                new Ingredient(IngredientEnum.ParmesanCheese),
                new Ingredient(IngredientEnum.CaesarDressing)
            }),
            new Salad("Caprese Salad", 2000,new List<Ingredient>()
            {
                new Ingredient(IngredientEnum.MozzarellaCheese),
                new Ingredient(IngredientEnum.SlicedTomatoes),
                new Ingredient(IngredientEnum.FreshBasil),
                new Ingredient(IngredientEnum.BalsamicGlaze)
            })
        };
        
        return menu;
    }
}