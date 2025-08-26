using Flyweight.Shapes.Interfaces;

namespace Flyweight.Shapes;
internal class Rectangle : IShape
{
    public void Print()
    {
        Console.WriteLine("Drawing Rectangle");
    }
}
