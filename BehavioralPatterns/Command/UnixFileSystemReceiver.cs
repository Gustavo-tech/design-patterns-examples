namespace Command;
internal class UnixFileSystemReceiver : IFileSystemReceiver
{
    public void CloseFile()
    {
        Console.WriteLine("Closing file in unix OS");
    }

    public void OpenFile()
    {
        Console.WriteLine("Opening file in unix OS");
    }

    public void WriteFile()
    {
        Console.WriteLine("Writing file in unix OS");
    }
}
