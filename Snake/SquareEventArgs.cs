// Project Snake: SquareEventArgs.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;

namespace Snake
{
    /// <summary>
    /// Provides data for the <see cref="Board.Updated"/> event.	
    /// </summary>
    public class SquareEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the square.
        /// </summary>
        /// <value>The square.</value>
        public Square Value { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SquareEventArgs"/> class.
        /// </summary>
        /// <param name="value">The square.</param>
        public SquareEventArgs(Square value)
        {
            this.Value = value;
        }
    }
}
