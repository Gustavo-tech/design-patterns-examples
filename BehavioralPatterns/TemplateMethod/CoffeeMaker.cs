namespace TemplateMethod;

internal class CoffeeMaker : BeverageMaker
{
    protected override void AddCondiments()
    {
        Console.WriteLine("Dripping coffee through filter");
    }

    protected override void Brew()
    {
        Console.WriteLine("Adding sugar and milk");
    }
}
