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
        /// <value>One of the enumeration values that specifies a direction of motion. The default is <see cref="Direction.None"/>.</value>
        public Direction Direction { get; }

        /// <summary>
        /// Gets the color of the player's pieces.
        /// </summary>
        /// <value>One of the enumeration values that specifies a color. The default is <see cref="Color.Light"/>.</value>
        public Color Color { get; }

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
