// Project Snake: Board.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;

namespace Snake
{
    /// <summary>
    /// Represents a rectangular board.
    /// </summary>
    public class Board
    {
        private readonly Piece[,] _pieces;

        /// <summary>
        /// Gets the piece on the given square.
        /// </summary>
        /// <param name="square">The square that contains the piece.</param>
        /// <value>The piece on the given square or <see langword="null"/> if the square is empty.</value>
        public Piece this[Square square]
        {
            get => this._pieces[square.X, square.Y];
        }

        /// <summary>
        /// Occurs when the board is updated.
        /// </summary>
        public event EventHandler<SquareEventArgs> Updated;

        /// <summary>
        /// Initializes a new instance of the <see cref="Board"/> class.
        /// </summary>
        public Board()
        {
            this._pieces = new Piece[Square.Files, Square.Ranks];
        }

        /// <summary>
        /// Gets the piece on the given square. A return value indicates whether the operation succeeded.
        /// </summary>
        /// <param name="square">The square that contains the piece.</param>
        /// <param name="result">When this method returns, contains the piece on the square, if a piece occupies the square, or <see langword="null"/> if square is empty. This parameter is treated as uninitialized.</param>
        /// <returns><see langword="true"/> if a piece occupies the square; otherwise, <see langword="false"/>.</returns>
        public bool TryGetPiece(Square square, out Piece result)
        {
            result = this[square];

            return result is not null;
        }

        /// <summary>
        /// Places a piece on an empty destination square.
        /// </summary>
        /// <param name="piece"></param>
        /// <param name="square"></param>
        public void Insert(Piece piece, Square square)
        {
            this.Move(piece, square, move: false);
        }

        /// <summary>
        /// Moves a given piece from its current square onto an empty destination square.
        /// </summary>
        /// <param name="piece">The piece.</param>
        /// <param name="square">The destination square.</param>
        /// <exception cref="InvalidOperationException">The given <paramref name="square"/> is not empty.</exception>
        /// <exception cref="ArgumentNullException">The given <paramref name="piece"/> is <see langword="null"/>.</exception>
        public void Move(Piece piece, Square square)
        {
            this.Move(piece, square, move: true);
        }

        private void Move(Piece piece, Square square, bool move)
        {
            if (this[square] is null)
            {
                if (piece is null)
                {
                    throw new ArgumentNullException(nameof(piece));
                }
                else
                {
                    piece.Board = this;

                    if (move)
                    {
                        Square oldSquare = piece.Square;

                        this._pieces[oldSquare.X, oldSquare.Y] = null;
                    }

                    piece.Square = square;

                    this._pieces[square.X, square.Y] = piece;

                    this.OnUpdated(new SquareEventArgs(square));
                }
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Raises the <see cref="Updated"/> event.
        /// </summary>
        /// <param name="e">The event data.</param>
        protected virtual void OnUpdated(SquareEventArgs e)
        {
            if (this.Updated is not null)
            {
                this.Updated.Invoke(sender: this, e);
            }
        }
    }
}
