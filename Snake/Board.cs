// Project Snake: Board.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

namespace Snake
{
    /// <summary>
    /// Represents a rectangular board.
    /// </summary>
    public class Board
    {
        private readonly Piece[,] _pieces;

        /// <summary>
        /// Gets or sets the piece on the given square. When reassiging an existing piece to a new square, the piece is removed from its original square. 
        /// </summary>
        /// <value>The piece on the given square or <see langword="null"/> if the square is empty.</value>
        public Piece this[Square square]
        {
            get => this._pieces[square.X, square.Y];
            set
            {
                if (value is not null)
                {
                    Square old = value.Square;

                    this._pieces[old.X, old.Y] = null;

                    value.Square = square;
                }

                this._pieces[square.X, square.Y] = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Board"/> class.
        /// </summary>
        public Board()
        {
            this._pieces = new Piece[Square.Files, Square.Ranks];
        }
    }
}