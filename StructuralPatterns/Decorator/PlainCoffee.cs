using Decorator.Interfaces;

namespace Decorator;
internal class PlainCoffee : ICoffee
{
    public string Description => "Plain coffee";
    public double Cost => 2.00;
}
