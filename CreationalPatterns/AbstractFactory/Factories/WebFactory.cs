using AbstractFactory.Components.Abstractions;
using AbstractFactory.Components.Web;
using AbstractFactory.Factories.Abstractions;

namespace AbstractFactory.Factories;

internal class WebFactory : Abstractions.GUIFactory
{
    internal override Button CreateButton() => new WebButton();
    internal override Checkbox CreateCheckbox() => new WebCheckbox();
}

