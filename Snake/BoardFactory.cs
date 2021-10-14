// Project Snake: BoardFactory.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

namespace Snake
{
    internal class BoardFactory 
    {
        public Board Create()
        {
            Board result = new Board();
            
            //for (int file = File.MinValue; file < File.Count; file++)
            //{
            //    result.Insert(new Piece(Player.))
            //}

            //for (char file = 'a'; file <= 'h'; file++)
            //{
            //    result.Insert(this._pieceFactory.CreatePawn(first), new Square(file, 2));
            //}

            //for (char file = 'a'; file <= 'h'; file++)
            //{
            //    result.Insert(this._pieceFactory.CreatePawn(second), new Square(file, 7));
            //}

            //result.Insert(this._pieceFactory.CreateRook(first), new Square('a', 1));
            //result.Insert(this._pieceFactory.CreateRook(first), new Square('h', 1));

            //result.Insert(this._pieceFactory.CreateRook(second), new Square('a', 8));
            //result.Insert(this._pieceFactory.CreateRook(second), new Square('h', 8));

            //result.Insert(this._pieceFactory.CreateKnight(first), new Square('b', 1));
            //result.Insert(this._pieceFactory.CreateKnight(first), new Square('g', 1));

            //result.Insert(this._pieceFactory.CreateKnight(second), new Square('b', 8));
            //result.Insert(this._pieceFactory.CreateKnight(second), new Square('g', 8));

            //result.Insert(this._pieceFactory.CreateBishop(first), new Square('c', 1));
            //result.Insert(this._pieceFactory.CreateBishop(first), new Square('f', 1));

            //result.Insert(this._pieceFactory.CreateBishop(second), new Square('c', 8));
            //result.Insert(this._pieceFactory.CreateBishop(second), new Square('f', 8));

            //result.Insert(this._pieceFactory.CreateQueen(first), new Square('d', 1));

            //result.Insert(this._pieceFactory.CreateQueen(second), new Square('d', 8));

            return result;
        }
    }
}
