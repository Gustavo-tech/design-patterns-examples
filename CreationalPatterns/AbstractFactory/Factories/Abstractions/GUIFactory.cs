using AbstractFactory.Components.Abstractions;

namespace AbstractFactory.Factories.Abstractions;

internal abstract class GUIFactory
{
    internal abstract Button CreateButton();
    internal abstract Checkbox CreateCheckbox();
}
