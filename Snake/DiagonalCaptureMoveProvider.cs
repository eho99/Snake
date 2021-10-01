// Project Snake: DiagonalMoveProvider.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System.Collections.Generic;

namespace Snake
{
    internal class DiagonalCaptureMoveProvider : IMoveProvider
    {
        public IEnumerable<IMove> GetMoves(Piece piece)
        {
            Square source = piece.Square;

            if (Square.TryCreate(source.X + 1, source.Y + (int) piece.Player.Direction, out Square result)) 
            {
                yield return new Move(piece, result);
            }

            if (Square.TryCreate(source.X - 1, source.Y + (int)piece.Player.Direction, out result))
            {
                yield return new Move(piece, result);
            }

        }
    }
}
