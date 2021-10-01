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
            Board board = piece.Board;

            if (Square.TryCreate(source.X + 1, source.Y + (int)piece.Player.Direction, out Square result) && board.TryGetPiece(result, out Piece target) == true && target.Player != piece.Player)
            {
                yield return new Move(piece, result);
            }

            if (Square.TryCreate(source.X - 1, source.Y + (int)piece.Player.Direction, out result) && board.TryGetPiece(result, out target) == true && target.Player != piece.Player)
            {
                yield return new Move(piece, result);
            }

        }
    }
}
