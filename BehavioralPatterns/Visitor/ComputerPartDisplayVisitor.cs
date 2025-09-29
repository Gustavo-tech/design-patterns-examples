namespace Visitor;

internal class ComputerPartDisplayVisitor : IComputerPartVisitor
{
    public void Visit(Keyboard keyboard)
    {
        Console.WriteLine("Displaying keyboard.");
    }

    public void Visit(Monitor monitor)
    {
        Console.WriteLine("Displaying monitor.");
    }
}
