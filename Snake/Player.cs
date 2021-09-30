// Project Snake: Player.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

namespace Snake
{
    /// <summary>
    /// Represents a player.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Gets the direction in which the player's pieces advance.
        /// </summary>
        public Direction Direction { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="direction">The direction in which the player's pieces advance.</param>
        public Player(Direction direction)
        {
            this.Direction = direction;
        }
    }
}
