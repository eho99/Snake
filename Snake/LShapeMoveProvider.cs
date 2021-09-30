using System;
using System.Collections.Generic;

namespace Snake
{
    internal class LShapeMoveProvider : IMoveProvider
    {
        public IEnumerable<IMove> GetMoves(Piece piece)
        {
            Square source = piece.Square;
            
            for (int i = 0; i < 8)
            /*
            for (int x = 0; x < Square.Files; x++)
            {
                for (int y = 0; y < Square.Ranks; y++)
                {
                    if (Math.Abs((double)(y - source.Y) / (x - source.X)) == 2 || Math.Abs((double)(y - source.Y) / (x - source.X)) == 0.5)
                    {
                        yield return new Move(piece, new Square(x, y));
                    }
                }
            }
            */


        }
    }
}
