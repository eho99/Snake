// Project Snake: AdvanceOneMoveProvider.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System.Collections.Generic;

namespace Snake
{
    internal class AdvanceOneMoveProvider : IMoveProvider
    {
        public IEnumerable<IMove> GetMoves(Piece piece)
        {
            Square source = piece.Square;

            yield return new Move(piece, new Square(source.X, source.Y + (int)piece.Player.Direction));
        }
    }
}
