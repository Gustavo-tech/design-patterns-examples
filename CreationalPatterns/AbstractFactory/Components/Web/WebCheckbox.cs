using AbstractFactory.Components.Abstractions;

namespace AbstractFactory.Components.Web;

internal class WebCheckbox : Checkbox
{
    internal override void OnClick()
    {
        IsMarked = !IsMarked;
        Console.WriteLine("You clicked on a web checkbox!");
    }
}
