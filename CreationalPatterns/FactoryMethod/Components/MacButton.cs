using FactoryMethod.Components.Abstractions;

namespace FactoryMethod.Components;

internal class MacButton : Button
{
    internal override void OnClick()
    {
        Console.WriteLine("You clicked on a mac button!");
    }
}
