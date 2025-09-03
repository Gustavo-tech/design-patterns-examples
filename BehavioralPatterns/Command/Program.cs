//Creating the receiver object
using Command;
using Command.Commands;

IFileSystemReceiver fs = FileSystemReceiverFactory.GetUnderlyingFileSystem();

//creating command and associating with receiver
OpenFileCommand openFileCommand = new(fs);

//Creating invoker and associating with Command
FileInvoker file = new(openFileCommand);

//perform action on invoker object
file.Execute();

WriteFileCommand writeFileCommand = new(fs);
file = new FileInvoker(writeFileCommand);
file.Execute();

CloseFileCommand closeFileCommand = new(fs);
file = new FileInvoker(closeFileCommand);
file.Execute();