using AbstractFactory.Components.Abstractions;

namespace AbstractFactory.Components.Web;

internal class WebButton : Button
{
    internal override void OnClick()
    {
        Console.WriteLine("You clicked on a web button!");
    }
}
