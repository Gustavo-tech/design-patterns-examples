using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento;

internal class Document
{
    internal string Content { get; set; } = "";

    internal Document(string content)
    {
        Content = content;
    }

    internal DocumentMemento CreateMemento()
    {
        return new DocumentMemento(Content);
    }

    internal void RestoreFromMemento(DocumentMemento documentMemento)
    {
        Content = documentMemento.Content;
    }

    internal void Write(string content)
    {
        Content += "\n" + content;
    }
}
