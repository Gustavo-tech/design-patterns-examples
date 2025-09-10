
namespace Memento;

internal class DocumentMemento
{
    public string Content { get; set; }

    public DocumentMemento(string content)
    {
        Content = content;
    }
}