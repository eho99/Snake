// Project Snake: Program.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;
using System.Collections.Generic;

namespace Snake.Application
{
    internal static class Program
    {
        private static void Main()
        {
            Board board = new Board();
            IPieceFactory pieceFactory = new PieceFactory();
            Player white = new Player();
            Piece rook = pieceFactory.CreateRook(white);

            foreach (Square square in Square.GetValues())
            {
                board[square] = rook;

                IEnumerable<IMove> moves = rook.GetMoves();

                Console.Write(rook);
                Console.Write(" on ");
                Console.Write(rook.Square);
                Console.Write(" can perform the following: ");
                Console.WriteLine(String.Join(", ", moves));
            }
        }
    }
}
