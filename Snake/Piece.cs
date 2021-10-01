// Project Snake: Piece.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    /// <summary>
    /// Represents a playing piece.
    /// </summary>
    public class Piece
    {
        private readonly IMoveProvider _moveProvider;

        /// <summary>
        /// Gets the player that owns the piece.
        /// </summary>
        /// <value>The player that owns the piece.</value>
        public Player Player { get; }

        /// <summary>
        /// Gets the symbol for the piece in algebraic notation.
        /// </summary>
        /// <value>The symbol for the piece.</value>
        public char Symbol { get; }

        /// <summary>
        /// Gets the square that contains the piece.
        /// </summary>
        /// <value>The square that contains the piece.</value>
        public Square Square { get; internal set; }

        /// <summary>
        /// Gets the board that contains the piece.
        /// </summary>
        /// <value>The board that contains the piece.</value>
        public Board Board { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Piece"/> class.
        /// </summary>
        /// <param name="player">The player that owns the piece.</param>
        /// <param name="symbol">The symbol for the piece in algebraic notation.</param>
        /// <param name="moveProvider">The move provider that defines the piece's abilities and range of movement.</param>
        public Piece(Player player, char symbol, IMoveProvider moveProvider)
        {
            this.Player = player;
            this.Symbol = symbol;
            this._moveProvider = moveProvider;
        }

        /// <summary>
        /// Gets a collection of legal moves for the piece.
        /// </summary>
        /// <returns>A collection of legal moves.</returns>
        public IEnumerable<IMove> GetMoves()
        {
            return this._moveProvider.GetMoves(this);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.Symbol.ToString();
        }
    }
}
