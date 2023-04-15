using RestaurantSimulator.Model.ServeAble;
using RestaurantSimulator.Model.BakeAble;
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
                new Ingredient("tomato sauce"),
                new Ingredient("mozzarella cheese"),
                new Ingredient("fresh basil")
            }),
            new Pizza("Pepperoni Pizza", 3600, new List<Ingredient>()
            {
                new Ingredient("tomato sauce"),
                new Ingredient("mozzarella cheese"),
                new Ingredient("Pepperoni")
            }),
            new Pizza("Hawaiian Pizza", 3600, new List<Ingredient>()
            {
                new Ingredient("tomato sauce"),
                new Ingredient("mozzarella cheese"),
                new Ingredient("ham"),
                new Ingredient("pineapple")
            }),
            new Pizza("Meat Lovers Pizza", 3600, new List<Ingredient>()
            {
                new Ingredient("tomato sauce"),
                new Ingredient("mozzarella cheese"),
                new Ingredient("pepperoni"),
                new Ingredient("sausage"),
                new Ingredient("bacon"),
                new Ingredient("ground beef")
            }),
            new Pizza("Veggie Pizza", 5600, new List<Ingredient>()
            {
                new Ingredient("tomato sauce"),
                new Ingredient("mozzarella cheese"),
                new Ingredient("mushrooms"),
                new Ingredient("green pepper"),
                new Ingredient("onion"),
                new Ingredient("olive")
            }),
            new Salad("Caesar Salad", 2000,new List<Ingredient>()
            {
                new Ingredient("romaine lettuce"),
                new Ingredient("croutons"),
                new Ingredient("parmesan cheese"),
                new Ingredient("Caesar dressing")
            }),
            new Salad("Caprese Salad", 2000,new List<Ingredient>()
            {
                new Ingredient("mozzarella cheese"),
                new Ingredient("sliced tomatoes"),
                new Ingredient("fresh basil"),
                new Ingredient("balsamic glaze")
            })
        };
        
        return menu;
    }
}