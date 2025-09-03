namespace Command;
internal interface IFileSystemReceiver
{
    void OpenFile();
    void WriteFile();
    void CloseFile();
}
