using Memento;

DocumentHistory history = new();
Document document = new("Initial content");
history.AddMemento(document.CreateMemento());

// Write some content
document.Write("Additional content");
history.AddMemento(document.CreateMemento());

// Write more content
document.Write("More content\n");
history.AddMemento(document.CreateMemento());

// Print current state
Console.WriteLine("====================== Before the restore =========================");
Console.WriteLine(document.Content);

Console.WriteLine();
Console.WriteLine("====================== After the restore =========================");

// Restore to previous state
document.RestoreFromMemento(history.GetMemento(1));

// Print previous content
Console.WriteLine(document.Content);