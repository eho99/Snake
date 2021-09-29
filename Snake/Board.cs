namespace Snake
{
    /// <summary>
    /// Represents a rectangular board.
    /// </summary>
    public class Board
    {
        private readonly Square[,] _squares;

        /// <summary>
        /// Gets the square at the given X and Y coordinates.
        /// </summary>
        /// <param name="x">The zero-based X coordinate that corresponds to one less than the file number.</param>
        /// <param name="y">The zero-based Y coordinate that corresponds to one less than the rank number.</param>
        /// <returns>The square at the given corrdinates.</returns>
        public Square this[int x, int y]
        {
            get
            {
                return this._squares[x, y];
            }
        }

        /// <summary>
        /// Gets the width of the board, in squares, that corresponds to the number of files.
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// Gets the height of the board, in squares, that corresponds to the number of ranks.
        /// </summary>
        public int Height { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Board"/> class.
        /// </summary>
        /// <param name="width">The width of the board, in squares, that corresponds to the number of files.</param>
        /// <param name="height">The height of the board, in squares, that corresponds to the number of ranks.</param>
        public Board(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            this._squares = new Square[width, height];
        }
    }
}