using RestaurantSimulator.Model.Enums;
using RestaurantSimulator.Model.MenuProvider;
using RestaurantSimulator.Model.ServeAble;

namespace RestaurantSimulator.Model.StockProvider;

public class StockProvider : IStockProvider
{
    public Dictionary<Ingredient,int> Ingredients { get; set; }
    public Dictionary<Drink,int> Drinks { get; set; }

    public StockProvider(IMenuProvider menuProvider)
    {
        Ingredients = GenerateIngredients();
        Drinks = GenerateDrinks();
    }

    private Dictionary<Ingredient,int> GenerateIngredients()
    {
        var ingredientDictionary = new Dictionary<Ingredient,int>()
        {
            {new Ingredient(IngredientEnum.TomatoSauce), 40},
            {new Ingredient(IngredientEnum.MozzarellaCheese), 40},
            {new Ingredient(IngredientEnum.FreshBasil), 40},
            {new Ingredient(IngredientEnum.Pepperoni), 40},
            {new Ingredient(IngredientEnum.Ham), 20},
            {new Ingredient(IngredientEnum.Pineapple), 20},
            {new Ingredient(IngredientEnum.Sausage), 20},
            {new Ingredient(IngredientEnum.Bacon), 20},
            {new Ingredient(IngredientEnum.GroundBeef), 20},
            {new Ingredient(IngredientEnum.Mushrooms), 20},
            {new Ingredient(IngredientEnum.GreenPepper), 20},
            {new Ingredient(IngredientEnum.Onion), 20},
            {new Ingredient(IngredientEnum.Olive), 20},
            {new Ingredient(IngredientEnum.RomaineLettuce), 20},
            {new Ingredient(IngredientEnum.Crouton), 20},
            {new Ingredient(IngredientEnum.ParmesanCheese), 20},
            {new Ingredient(IngredientEnum.CaesarDressing), 20},
            {new Ingredient(IngredientEnum.SlicedTomatoes), 20},
            {new Ingredient(IngredientEnum.BalsamicGlaze), 20},
        };
        return ingredientDictionary;
    }
    
    private Dictionary<Drink,int> GenerateDrinks()
    {
        var drinks = new Dictionary<Drink, int>()
        {
            {new Drink("Coca-cola", 600),20},
            {new Drink("Light Coca-cola", 600),20},
            {new Drink("Zero Coca-cola", 600),5},
            {new Drink("Sprite", 600),20},
            {new Drink("Water", 400),20},
            {new Drink("Soda", 400),20}
        };
        return drinks;
    }
    
}