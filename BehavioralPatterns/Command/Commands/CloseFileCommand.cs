﻿using Command.Commands.Interfaces;

namespace Command.Commands;

internal class CloseFileCommand(IFileSystemReceiver fileSystem) : ICommand
{
    private readonly IFileSystemReceiver _fileSystem = fileSystem ?? throw new ArgumentNullException(nameof(fileSystem));

    public void Execute()
    {
        _fileSystem.OpenFile();
    }
}
