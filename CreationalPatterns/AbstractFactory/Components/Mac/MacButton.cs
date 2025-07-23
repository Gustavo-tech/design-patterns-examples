using AbstractFactory.Components.Abstractions;

namespace AbstractFactory.Components.Mac;

internal class MacButton : Button
{
    internal override void OnClick()
    {
        Console.WriteLine("You clicked on a mac button!");
    }
}
