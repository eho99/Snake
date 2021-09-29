using System;
using System.Collections.Generic;

namespace Snake
{
    /// <summary>
    /// Represents a square on a board.
    /// </summary>
    public readonly struct Square
    {
        private const string Alphabet = "abcdefgh";

        /// <summary>
        /// Specifies the maximum value for the <see cref="Rank"/> property.
        /// </summary>
        public const int MaxRank = Ranks;

        /// <summary>
        /// Specifies the maximum value for the <see cref="File"/> property.
        /// </summary>
        public const char MaxFile = 'h';

        /// <summary>
        /// Specifies the number of ranks.
        /// </summary>
        public const int Ranks = 8;

        /// <summary>
        /// Specifies the number of files.
        /// </summary>
        public const int Files = 8;

        /// <summary>
        /// Gets the zero-based horizontal coordinate of the square.
        /// </summary>
        /// <value>The zero-based horizontal coordinate. The default is <c>0</c>.</value>
        public int X { get; }

        /// <summary>
        /// Gets the zero-based vertical coordinate of the square.
        /// </summary>
        /// <value>The zero-based vertical coordinate. The default is <c>0</c>.</value>
        public int Y { get; }

        /// <summary>
        /// Gets the rank number of the square.
        /// </summary>
        /// <value>The rank number. The default is <c>1</c>.</value>
        public int Rank
        {
            get
            {
                return MaxRank - this.Y;
            }
        }

        /// <summary>
        /// Gets the file letter of the square.
        /// </summary>
        /// <value>The file letter. The default is <c>A</c>.</value>
        public char File
        {
            get
            {
                return Alphabet[this.X];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> struct.	
        /// </summary>
        /// <param name="x">The zero-based horizontal coordinate.</param>
        /// <param name="y">The zero-based vertical coordinate.</param>
        public Square(int x, int y)
        {
            if (x < 0 || x > Files)
            {
                throw new ArgumentOutOfRangeException(nameof(x));
            }
            else
            {
                this.X = x;
            }

            if (y < 0 || y > Ranks)
            {
                throw new ArgumentOutOfRangeException(nameof(y));
            }
            else
            {
                this.Y = y;
            }
        }

        /// <summary>
        /// Gets a collection of new <see cref="Square"/> instances that represent all the possible values.
        /// </summary>
        /// <returns>A collection of new <see cref="Square"/> instances.</returns>
        public static IEnumerable<Square> GetValues()
        {
            for (int x = 0; x < Files; x++)
            {
                for (int y = 0; y < Ranks; y++)
                {
                    yield return new Square(x, y);
                }
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.File.ToString() + this.Rank;
        }
    }
}
