namespace Command;
internal class FileSystemReceiverFactory
{
    internal static IFileSystemReceiver GetUnderlyingFileSystem()
    {
        string osName = Environment.OSVersion.Platform.ToString();
        Console.WriteLine(osName);

        if (osName.Contains("Win"))
        {
            return new WindowsFileSystemReceiver();
        }
        else if (osName.Contains("Unix"))
        {
            return new UnixFileSystemReceiver();
        }
        else
        {
            throw new Exception("Operating system not supported");
        }
    }
}
