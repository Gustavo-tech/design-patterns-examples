namespace Memento;

internal class DocumentHistory
{
    private List<DocumentMemento> _documentMementos = new();

    internal void AddMemento(DocumentMemento memento)
    {
        _documentMementos.Add(memento);
    }

    internal DocumentMemento GetMemento(int index)
    {
        return _documentMementos[index];
    }
}
