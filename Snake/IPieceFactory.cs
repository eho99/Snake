// Project Snake: IPieceFactory.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

namespace Snake
{
    /// <summary>
    /// Defines methods for creating instances of the <see cref="Piece"/> class.
    /// </summary>
    public interface IPieceFactory
    {
        /// <summary>
        /// Creates a new instance of the <see cref="Piece"/> class, initialized as a rook.
        /// </summary>
        /// <param name="player">The player that owns the piece.</param>
        /// <returns>The new rook piece.</returns>
        Piece CreateRook(Player player);

        /// <summary>
        /// Creates a new instance of the <see cref="Piece"/> class, initialized as a bishop.
        /// </summary>
        /// <param name="player">The player that owns the piece.</param>
        /// <returns>The new bishop piece.</returns>
        Piece CreateBishop(Player player);

        /// <summary>
        /// Creates a new instance of the <see cref="Piece"/> class, initialized as a queen.
        /// </summary>
        /// <param name="player">The player that owns the piece.</param>
        /// <returns>The new queen piece.</returns>
        Piece CreateQueen(Player player);

        /// <summary>
        /// Creates a new instance of the <see cref="Piece"/> class, initialized as a knight.
        /// </summary>
        /// <param name="player">The player that owns the piece.</param>
        /// <returns>The new knight piece.</returns>
        Piece CreateKnight(Player player);

        /// <summary>
        /// Creates a new instance of the <see cref="Piece"/> class, initialized as a pawn.
        /// </summary>
        /// <param name="player">The player that owns the piece.</param>
        /// <returns>The new pawn piece.</returns>
        Piece CreatePawn(Player player);
    }
}
