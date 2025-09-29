namespace Visitor;

internal class Monitor : IComputerPart
{
    public void Accept(IComputerPartVisitor computerPartVisitor)
    {
        computerPartVisitor.Visit(this);
    }
}
