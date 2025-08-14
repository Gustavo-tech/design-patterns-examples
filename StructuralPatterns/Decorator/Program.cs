using Decorator;
using Decorator.Interfaces;

PlainCoffee coffee = new();
Console.WriteLine("Description: " + coffee.Description);
Console.WriteLine("Cost: " + coffee.Cost);

ICoffee milkCoffee = new MilkDecorator(coffee);
Console.WriteLine("Description: " + milkCoffee.Description);
Console.WriteLine("Cost: " + milkCoffee.Cost);

ICoffee sugarMilkCoffee = new SugarDecorator(milkCoffee);
Console.WriteLine("Description: " + sugarMilkCoffee.Description);
Console.WriteLine("Cost: " + sugarMilkCoffee.Cost);