// Project Snake: Player.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

namespace Snake
{
    /// <summary>
    /// Specifies a direction of motion.
    /// </summary>
    public enum Direction
    {
        /// <summary>
        /// The back-to-front direction, beginning from the first rank and advancing toward the eighth rank.
        /// </summary>
        Forward = -1,

        /// <summary>
        /// No specified direction.
        /// </summary>
        None = 0,

        /// <summary>
        /// The front-to-back direction, beginning from the eighth rank and advancing toward the first rank.
        /// </summary>
        Backward = 1,
    }
}
