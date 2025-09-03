namespace Command;
internal class WindowsFileSystemReceiver : IFileSystemReceiver
{
    public void CloseFile()
    {
        Console.WriteLine("Closing file in unix Windows");
    }

    public void OpenFile()
    {
        Console.WriteLine("Opening file in unix Windows");
    }

    public void WriteFile()
    {
        Console.WriteLine("Writing file in unix Windows");
    }
}
