namespace Visitor;

internal interface IComputerPartVisitor
{
    void Visit(Keyboard keyboard);
    void Visit(Monitor monitor);
}