// Project Snake: IBoardViewContext.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

namespace Snake.Application.Windows
{
    internal interface IBoardViewContext
    {
        Board Board { get; }

        void SetState(IBoardViewState value);

        void Select(Square square);

        void Reset();
        void Highlight(Square square);
        void Unhiglight(Square square);
        void Present(IMove move);
    }
}
