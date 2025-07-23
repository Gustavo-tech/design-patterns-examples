using AbstractFactory.Components.Abstractions;

namespace AbstractFactory.Components.Windows;

internal class WindowsCheckbox : Checkbox
{
    internal override void OnClick()
    {
        IsMarked = !IsMarked;
        Console.WriteLine("You clicked on a windows checkbox!");
    }
}
