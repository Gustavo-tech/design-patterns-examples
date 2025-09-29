namespace Visitor;

internal interface IComputerPart
{
    void Accept(IComputerPartVisitor computerPartVisitor);
}
