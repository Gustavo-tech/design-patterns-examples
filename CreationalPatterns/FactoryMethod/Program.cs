using FactoryMethod;
using FactoryMethod.Components.Abstractions;
using FactoryMethod.Dialogs.Abstractions;

string environmentType = "web";
CreateDialogAndClickOnButton(environmentType);

environmentType = "mac";
CreateDialogAndClickOnButton(environmentType);

environmentType = "windows";
CreateDialogAndClickOnButton(environmentType);

static void CreateDialogAndClickOnButton(string environmentType)
{
    Dialog dialog = DialogFactory.CreateDialog(environmentType);
    Button button = dialog.CreateButton();
    button.OnClick();
}