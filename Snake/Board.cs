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
        /// Gets or sets the piece on the given square. When reassiging an existing piece to a new square, the piece is removed from its original square. Any existing piece on the destination square is removed from the board.
        /// </summary>
        /// <value>The piece on the given square or <see langword="null"/> if the square is empty.</value>
        public Piece this[Square square]
        {
            get => this._pieces[square.X, square.Y];
            set
            {
                Piece oldPiece = this[square];

                if (oldPiece is not null)
                {
                    oldPiece.Board = null;
                }

                if (value is not null)
                {
                    value.Board = this;

                    Square oldSquare = value.Square;

                    this._pieces[oldSquare.X, oldSquare.Y] = null;

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
