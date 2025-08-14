using Decorator.Interfaces;

namespace Decorator;
internal class SugarDecorator : CoffeeDecorator
{
    public override string Description => coffee.Description + ", Sugar";
    public override double Cost => coffee.Cost + 0.2;

    public SugarDecorator(ICoffee coffeeToDecorate) : base(coffeeToDecorate)
    {
    }
}
