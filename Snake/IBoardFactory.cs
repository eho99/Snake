// Project Snake: IBoardFactory.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

namespace Snake
{
    /// <summary>
    /// Defines a method for creating instances of the <see cref="Board"/> class.
    /// </summary>
    public interface IBoardFactory
    {
        /// <summary>
        /// Creates a new instance of the <see cref="Board"/> class.
        /// </summary>
        /// <param name="first">The first player.</param>
        /// <param name="second">The second player.</param>
        /// <returns>The new board.</returns>
        Board Create(Player first, Player second);
    }
}
