﻿// Project Snake: DiagonalMoveProvider.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;
using System.Collections.Generic;

namespace Snake
{
    internal class AdvanceOneMoveProvider : IMoveProvider
    {
        public IEnumerable<IMove> GetMoves(Piece piece)
        {
            Square source = piece.Square;

            if (Square.TryCreate(source.X, source.Y + (int)piece.Player.Direction, out Square result))
            {
                yield return new Move(piece, result);
            }

        }
    }
}
