// Project Snake: Move.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

namespace Snake
{
    internal class Move : IMove
    {
        public Piece Piece { get; }
        public Square Destination { get; }

        public Move(Piece piece, Square destination)
        {
            this.Piece = piece;
            this.Destination = destination;
        }

        public override string ToString()
        {
            return this.Piece.ToString() + this.Destination.ToString();
        }
    }
}