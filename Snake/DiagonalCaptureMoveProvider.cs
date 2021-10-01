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

            yield return new Move(piece, new Square(source.X + 1, source.Y + (int)piece.Player.Direction));
            yield return new Move(piece, new Square(source.X - 1, source.Y + (int)piece.Player.Direction));
        }
    }
}
