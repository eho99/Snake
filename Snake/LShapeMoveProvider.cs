using System;
using System.Collections.Generic;

namespace Snake
{
    internal class LShapeMoveProvider : IMoveProvider
    {
        public IEnumerable<IMove> GetMoves(Piece piece)
        {
            Square source = piece.Square;

            yield return new Move(piece, new Square(source.X, source.Y));



        }
    }
}
