// Project Snake: OrthogonalMoveProvider.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System.Collections.Generic;

namespace Snake
{
    internal class OrthogonalMoveProvider : IMoveProvider
    {
        public IEnumerable<IMove> GetMoves(Piece piece)
        {
            Square source = piece.Square;

            for (int x = 0; x < Square.Files; x++)
            {
                if (x != source.X)
                {
                    yield return new Move(piece, new Square(x, source.Y));
                }
            }

            for (int y = 0; y < Square.Ranks; y++)
            {
                if (y != source.Y)
                {
                    yield return new Move(piece, new Square(source.X, y));
                }
            }
        }
    }
}
