// Project Snake: Program.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake.Application
{
    internal static class Program
    {
        private static void Main()
        {
            Board board = new Board();
            IPieceFactory pieceFactory = new PieceFactory();
            Player white = new Player(Direction.Forward, Color.Light);
            Piece piece = pieceFactory.CreateRook(white);
            Square first = new Square();

            board.Insert(piece, first);

            foreach (Square square in Square.GetValues())
            {
                if (square != first)
                {
                    board.Move(piece, square);

                    List<IMove> moves = piece.GetMoves().ToList();

                    Console.Write(piece);
                    Console.Write(" on ");
                    Console.Write(piece.Square);
                    Console.Write(" can perform ");
                    Console.Write(moves.Count + " moves: ");
                    Console.WriteLine(String.Join(", ", moves));
                }
            }
        }
    }
}
