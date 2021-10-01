// Project Snake: LShapeMoveProvider.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System.Collections.Generic;

namespace Snake
{
    internal class LShapeMoveProvider : IMoveProvider
    {
        public IEnumerable<IMove> GetMoves(Piece piece)
        {
            Square source = piece.Square;

            if (Square.TryCreate(source.X + 2, source.Y + 1, out Square result))
            {
                yield return new Move(piece, result);
            }

            if (Square.TryCreate(source.X + 2, source.Y - 1, out result))
            {
                yield return new Move(piece, result);
            }

            if (Square.TryCreate(source.X + 1, source.Y + 2, out result))
            {
                yield return new Move(piece, result);
            }

            if (Square.TryCreate(source.X + 1, source.Y - 2, out result))
            {
                yield return new Move(piece, result);
            }

            if (Square.TryCreate(source.X - 2, source.Y + 1, out result))
            {
                yield return new Move(piece, result);
            }

            if (Square.TryCreate(source.X - 2, source.Y - 1, out result))
            {
                yield return new Move(piece, result);
            }

            if (Square.TryCreate(source.X - 1, source.Y + 2, out result))
            {
                yield return new Move(piece, result);
            }

            if (Square.TryCreate(source.X - 1, source.Y - 2, out result))
            {
                yield return new Move(piece, result);
            }
        }
    }
}
