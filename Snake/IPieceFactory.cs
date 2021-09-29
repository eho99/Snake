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
    }
}
