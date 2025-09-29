using Visitor;
using Monitor = Visitor.Monitor;

IComputerPartVisitor computerPartVisitor = new ComputerPartDisplayVisitor();
computerPartVisitor.Visit(new Keyboard());
computerPartVisitor.Visit(new Monitor());