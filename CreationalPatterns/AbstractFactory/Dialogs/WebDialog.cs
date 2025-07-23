using AbstractFactory.Components.Abstractions;
using AbstractFactory.Components.Web;
using AbstractFactory.Dialogs.Abstractions;

namespace AbstractFactory.Dialogs;

internal class WebDialog : Dialog
{
    internal override Button CreateButton() => new WebButton();
}

