using System.Collections.Generic;

namespace Snake
{
    /// <summary>
    /// Defines a method for creating collections of moves.
    /// </summary>
    public interface IMoveProvider
    {
        /// <summary>
        /// Gets a collection of moves for a given piece.
        /// </summary>
        /// <param name="piece">The piece.</param>
        /// <returns>A collection of moves.</returns>
        IEnumerable<IMove> GetMoves(Piece piece);
    }
}