// Project Snake: BoardViewContext.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System.Collections.Generic;

namespace Snake.Application.Windows
{
    internal class InitialBoardViewState : IBoardViewState
    {
        public void Select(Square square, IBoardViewContext context)
        {
            if (context.Board.TryGetPiece(square, out Piece piece))
            {
                context.Highlight(square);

                IEnumerable<IMove> moves = piece.GetMoves();

                foreach (IMove move in moves)
                {
                    context.Present(move);
                }

                context.SetState(new SelectedBoardViewState(piece, moves));
            }
        }
    }
}
