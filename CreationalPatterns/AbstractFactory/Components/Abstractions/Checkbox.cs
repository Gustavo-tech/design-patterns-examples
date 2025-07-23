namespace AbstractFactory.Components.Abstractions;

internal abstract class Checkbox
{
    internal bool IsMarked { get; set; }
    internal abstract void OnClick();
}
