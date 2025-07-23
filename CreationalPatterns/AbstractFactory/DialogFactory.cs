using AbstractFactory.Dialogs;
using AbstractFactory.Dialogs.Abstractions;

namespace AbstractFactory;

internal static class DialogFactory
{
    internal static Dialog CreateDialog(string environmentType)
    {
        return environmentType switch
        {
            "web" => new WebDialog(),
            "mac" => new MacDialog(),
            _ => new WindowsDialog(),
        };
    }
}
