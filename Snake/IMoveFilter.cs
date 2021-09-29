﻿using System.Collections.Generic;

namespace Snake
{
    /// <summary>
    /// Defines a method for filtering collections of moves.
    /// </summary>
    internal interface IMoveFilter
    {
        /// <summary>
        /// Removes inappropriate moves from the given collection.
        /// </summary>
        /// <param name="moves">The collection of moves.</param>
        void Filter(ICollection<IMove> moves);
    }
}