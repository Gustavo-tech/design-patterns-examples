using AbstractFactory.Components.Abstractions;
using AbstractFactory.Components.Mac;
using AbstractFactory.Factories.Abstractions;

namespace AbstractFactory.Factories;

internal class MacFactory : Abstractions.GUIFactory
{
    internal override Button CreateButton() => new MacButton();
    internal override Checkbox CreateCheckbox() => new MacCheckbox();
}

