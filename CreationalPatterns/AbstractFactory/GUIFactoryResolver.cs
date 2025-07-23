using AbstractFactory.Factories;
using AbstractFactory.Factories.Abstractions;

namespace AbstractFactory;

internal static class GUIFactoryResolver
{
    internal static GUIFactory CreateFactory(string environmentType)
    {
        return environmentType switch
        {
            "web" => new WebFactory(),
            "mac" => new MacFactory(),
            _ => new WindowsFactory(),
        };
    }
}
