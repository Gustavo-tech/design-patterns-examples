using AbstractFactory.Components.Abstractions;

namespace AbstractFactory.Components.Mac;

internal class MacCheckbox : Checkbox
{
    internal override void OnClick()
    {
        IsMarked = !IsMarked;
        Console.WriteLine("You clicked on a mac checkbox!");
    }
}
