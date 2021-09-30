// Project Snake: DiagonalMoveProvider.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;
using System.Collections.Generic;

namespace Snake
{
    internal class DiagonalMoveProvider : IMoveProvider
    {
        public IEnumerable<IMove> GetMoves(Piece piece)
        {
            Square source = piece.Square;

            for (int x = 0; x < Square.Files; x++)
            {
                for (int y = 0; y < Square.Ranks; y++)
                {
                    if (Math.Abs((double)(y - source.Y) / (x - source.X)) == 1)
                    {
                        yield return new Move(piece, new Square(x, y));
                    }
                }
            }
        }
    }
}
