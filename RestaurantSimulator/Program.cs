// See https://aka.ms/new-console-template for more information

using RestaurantSimulator.Model.MenuProvider;
using RestaurantSimulator.Service;

var basicMenu = new BasicMenu();
var restaurant = new Restaurant(basicMenu);

restaurant.TakeMenu();