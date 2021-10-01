// Project Snake: IBoardViewState.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

namespace Snake.Application.Windows
{
    internal interface IBoardViewState
    {
        void Select(Square square, IBoardViewContext context);
    }
}
