using FactoryMethod.Components.Abstractions;

namespace FactoryMethod.Components;

internal class WebButton : Button
{
    internal override void OnClick()
    {
        Console.WriteLine("You clicked on a web button!");
    }
}
