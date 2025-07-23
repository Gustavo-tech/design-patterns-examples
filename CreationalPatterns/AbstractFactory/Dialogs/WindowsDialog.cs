using AbstractFactory.Components.Abstractions;
using AbstractFactory.Components.Windows;
using AbstractFactory.Dialogs.Abstractions;

namespace AbstractFactory.Dialogs;

internal class WindowsDialog : Dialog
{
    internal override Button CreateButton() => new WindowsButton();
}

