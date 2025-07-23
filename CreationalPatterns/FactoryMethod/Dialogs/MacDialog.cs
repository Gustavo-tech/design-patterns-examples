using FactoryMethod.Components;
using FactoryMethod.Components.Abstractions;
using FactoryMethod.Dialogs.Abstractions;

namespace FactoryMethod.Dialogs;

internal class MacDialog : Dialog
{
    internal override Button CreateButton() => new MacButton();
}

