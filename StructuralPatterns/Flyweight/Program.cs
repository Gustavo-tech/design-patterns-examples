using Flyweight;
using Flyweight.Shapes.Interfaces;

ShapeFactory shapeFactory = new();
IShape circle1 = shapeFactory.GetShape("circle");
circle1.Print();

IShape circle2 = shapeFactory.GetShape("circle");
circle2.Print();

IShape square = shapeFactory.GetShape("square");
square.Print();

IShape rectangle = shapeFactory.GetShape("rectangle");
rectangle.Print();

Console.WriteLine($"Total objects created: {shapeFactory.TotalObjectsCreated}");