using AbstractFactory.Components.Abstractions;
using AbstractFactory.Components.Mac;
using AbstractFactory.Dialogs.Abstractions;

namespace AbstractFactory.Dialogs;

internal class MacDialog : Dialog
{
    internal override Button CreateButton() => new MacButton();
}

