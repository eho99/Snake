// Project Snake: IUnexecutableCommand.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

namespace Snake.Application.Windows
{
    internal interface IUnexecutableCommand : ICommand
    {
        void Unexecute();
    }
}
