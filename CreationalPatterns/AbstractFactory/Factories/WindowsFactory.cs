using AbstractFactory.Components.Abstractions;
using AbstractFactory.Components.Windows;
using AbstractFactory.Factories.Abstractions;

namespace AbstractFactory.Factories;

internal class WindowsFactory : Abstractions.GUIFactory
{
    internal override Button CreateButton() => new WindowsButton();
    internal override Checkbox CreateCheckbox() => new WindowsCheckbox();
}

