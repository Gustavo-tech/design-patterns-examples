using FactoryMethod.Dialogs;
using FactoryMethod.Dialogs.Abstractions;

namespace FactoryMethod;

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
