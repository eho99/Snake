// Project Snake: IMove.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

namespace Snake
{
    /// <summary>
    /// Defines a move.
    /// </summary>
    public interface IMove
    {
        /// <summary>
        /// Gets the destination square.
        /// </summary>
        /// <value>The destination square.</value>
        Square Destination { get; }

        /// <summary>
        /// Performs the move on the given board.
        /// </summary>
        /// <param name="board">The board.</param>
        void Execute(Board board);
    }
}
