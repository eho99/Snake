// Project Snake: DiagonalMoveProvider.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;
using System.Collections.Generic;

namespace Snake
{
    internal class DiagonalCaptureMoveProvider : IMoveProvider
    {
        public IEnumerable<IMove> GetMoves(Piece piece)
        {
            Square source = piece.Square;

            //need to check if there is a piece on the squares the pawn can capture on
          
                yield return new Move(piece, new Square(source.X + 1, source.Y + (int)piece.Player.Direction));
                yield return new Move(piece, new Square(source.X - 1, source.Y + (int)piece.Player.Direction));
    }
}
