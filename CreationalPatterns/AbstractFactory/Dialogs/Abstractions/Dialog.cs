using AbstractFactory.Components.Abstractions;

namespace AbstractFactory.Dialogs.Abstractions;

internal abstract class Dialog
{
    internal abstract Button CreateButton();
}
