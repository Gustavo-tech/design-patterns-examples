using Flyweight.Shapes.Interfaces;

namespace Flyweight.Shapes;
internal class Circle : IShape
{
    public void Print()
    {
        Console.WriteLine("Drawing circle");
    }
}
