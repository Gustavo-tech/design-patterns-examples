using FactoryMethod.Components.Abstractions;

namespace FactoryMethod.Components;

internal class WindowsButton : Button
{
    internal override void OnClick()
    {
        Console.WriteLine("You clicked on a windows button!");
    }
}
