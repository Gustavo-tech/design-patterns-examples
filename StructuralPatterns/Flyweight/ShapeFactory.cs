using Flyweight.Shapes;
using Flyweight.Shapes.Interfaces;

namespace Flyweight;
internal class ShapeFactory
{
    private readonly Dictionary<string, IShape> _shapes = [];

    internal int TotalObjectsCreated => _shapes.Count;

    public IShape GetShape(string shapeType)
    {
        if (_shapes.ContainsKey(shapeType))
        {
            return _shapes[shapeType];
        }
        IShape shape = shapeType.ToLower() switch
        {
            "circle" => new Circle(),
            "square" => new Square(),
            "rectangle" => new Rectangle(),
            _ => throw new ArgumentException("Invalid shape type"),
        };
        _shapes[shapeType] = shape;
        return shape;
    }
}
