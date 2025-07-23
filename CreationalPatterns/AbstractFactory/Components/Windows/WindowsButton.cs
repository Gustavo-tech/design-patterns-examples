using AbstractFactory.Components.Abstractions;

namespace AbstractFactory.Components.Windows;

internal class WindowsButton : Button
{
    internal override void OnClick()
    {
        Console.WriteLine("You clicked on a windows button!");
    }
}
