namespace TemplateMethod;

internal class TeaMaker : BeverageMaker
{
    protected override void AddCondiments()
    {
        Console.WriteLine("Steeping the  tea");
    }

    protected override void Brew()
    {
        Console.WriteLine("Adding lemon");
    }
}
