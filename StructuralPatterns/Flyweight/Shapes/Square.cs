using Flyweight.Shapes.Interfaces;

namespace Flyweight.Shapes;
internal class Square : IShape
{
    public void Print()
    {
        Console.WriteLine("Drawing Square");
    }
}
