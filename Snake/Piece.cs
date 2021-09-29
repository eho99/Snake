namespace Snake
{
    /// <summary>
    /// Represents a playing piece.
    /// </summary>
    public abstract class Piece
    {
        /// <summary>
        /// Gets the player that owns the piece.
        /// </summary>
        /// <value>The player that owns the piece.</value>
        public Player Player { get; }


    }
}