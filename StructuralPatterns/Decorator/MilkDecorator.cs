using Decorator.Interfaces;

namespace Decorator;
internal class MilkDecorator : CoffeeDecorator
{
    public override string Description => coffee.Description + ", Milk";
    public override double Cost => coffee.Cost + 0.5;

    public MilkDecorator(ICoffee coffeeToDecorate) : base(coffeeToDecorate)
    {

    }
}
