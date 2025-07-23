using AbstractFactory;
using AbstractFactory.Components.Abstractions;
using AbstractFactory.Factories.Abstractions;

string environmentType = "web";
CreateGUIAndClickOnComponents(environmentType);

environmentType = "mac";
CreateGUIAndClickOnComponents(environmentType);

environmentType = "windows";
CreateGUIAndClickOnComponents(environmentType);

static void CreateGUIAndClickOnComponents(string environmentType)
{
    GUIFactory factory = GUIFactoryResolver.CreateFactory(environmentType);

    Button button = factory.CreateButton();
    button.OnClick();

    Checkbox checkbox = factory.CreateCheckbox();
    checkbox.OnClick();

    Console.WriteLine($"is marked: {checkbox.IsMarked}");
    Console.WriteLine();
}