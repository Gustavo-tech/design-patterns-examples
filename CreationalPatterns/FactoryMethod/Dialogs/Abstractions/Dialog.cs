using FactoryMethod.Components.Abstractions;

namespace FactoryMethod.Dialogs.Abstractions;

internal abstract class Dialog
{
    internal abstract Button CreateButton();
}
