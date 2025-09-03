// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




IMilk drink = new Latte();
Console.WriteLine($"Latte contains {drink.MlMilk()} ml of milk.");


var cortado = new Cortado();
var latte = new Latte();
var blackCoffee = new BlackCoffee();

List<Coffee> coffeeList = new List<Coffee> { cortado, latte, blackCoffee };

foreach (var coffee in coffeeList)
{
	Console.WriteLine($"Cost: {coffee.Cost()} DKK, Strength: {coffee.Strength}");
}


