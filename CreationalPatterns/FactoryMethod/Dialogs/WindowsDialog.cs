using FactoryMethod.Components;
using FactoryMethod.Components.Abstractions;
using FactoryMethod.Dialogs.Abstractions;

namespace FactoryMethod.Dialogs;

internal class WindowsDialog : Dialog
{
    internal override Button CreateButton() => new WindowsButton();
}

