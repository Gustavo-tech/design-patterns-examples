using Decorator.Interfaces;

namespace Decorator;
internal abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee coffee;

    public abstract string Description { get; }
    public abstract double Cost { get; }

    public CoffeeDecorator(ICoffee coffeeToDecorate)
    {
        coffee = coffeeToDecorate;
    }
}
