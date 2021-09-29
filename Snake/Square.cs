namespace Snake
{
    /// <summary>
    /// Represents a square on a board.
    /// </summary>
    public class Square
    {
        /// <summary>
        /// Gets a value that indicates whether the square is empty.
        /// </summary>
        /// <value><see langword="true"/> if the square does not contain a piece; otherwise, <see langword="false"/>.</value>
        public bool Empty
        {
            get
            {
                return this.Piece is null;
            }
        }

        /// <summary>
        /// Gets or sets the piece that occupies the square.
        /// </summary>
        /// <value>The piece that occupies the square or <see langword="null"/> if the square is empty. The default is <see langword="null"/>.</value>
        public Piece Piece { get; set; }
    }
}