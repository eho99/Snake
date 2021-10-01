// Project Snake: Square.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;
using System.Collections.Generic;

namespace Snake
{
    /// <summary>
    /// Represents a square on a board.
    /// </summary>
    public readonly struct Square : IEquatable<Square>
    {
        private const string Alphabet = "abcdefgh";
        private const int MinRank = 1;

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
        /// <value>The rank number. The default is <c>8</c>.</value>
        public int Rank
        {
            get => Ranks - this.Y;
        }

        /// <summary>
        /// Gets the file letter of the square.
        /// </summary>
        /// <value>The file letter. The default is <c>'a'</c>.</value>
        public char File
        {
            get => Alphabet[this.X];
        }

        /// <summary>
        /// Gets the color of the square.
        /// </summary>
        /// <value>One of the enumeration values that specifies a color.</value>
        public Color Color
        {
            get => (Color)(((this.X + this.Y) % 2) + 1);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> struct.	
        /// </summary>
        /// <param name="file">The file letter.</param>
        /// <param name="rank">The rank number.</param>
        /// <exception cref="ArgumentException">The case-insensitive value of the <paramref name="file"/> parameter is not <c>'a'</c>, <c>'b'</c>, <c>'c'</c>, <c>'d'</c>, <c>'e'</c>, <c>'f'</c>, <c>'g'</c>, or <c>'h'</c>.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The value of the <paramref name="rank"/> parameter is less than <c>1</c> or greater than <c>8</c>.</exception>
        public Square(char file, int rank)
        {
            file = Char.ToLower(file);

            char minFile = Alphabet[0];

            if (file < minFile || file > (minFile + Files))
            {
                throw new ArgumentException($"'{file}' is not a valid file letter. The case-insensitive value must be 'a', 'b', 'c', 'd', 'e', 'f', 'g', or 'h'.", nameof(file));
            }
            else
            {
                this.X = file - minFile;
            }

            if (rank < MinRank || rank > Ranks)
            {
                throw new ArgumentOutOfRangeException(nameof(rank));
            }
            else
            {
                this.Y = rank - MinRank;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> struct.	
        /// </summary>
        /// <param name="x">The zero-based horizontal coordinate.</param>
        /// <param name="y">The zero-based vertical coordinate.</param>
        /// <exception cref="ArgumentOutOfRangeException">The value of the <paramref name="x"/> or <paramref name="y"/> parameter is less than <c>0</c> or greater than <c>7</c>.</exception>
        public Square(int x, int y)
        {
            if (x < 0 || x >= Files)
            {
                throw new ArgumentOutOfRangeException(nameof(x));
            }
            else
            {
                this.X = x;
            }

            if (y < 0 || y >= Ranks)
            {
                throw new ArgumentOutOfRangeException(nameof(y));
            }
            else
            {
                this.Y = y;
            }
        }

        /// <summary>
        /// Converts the zero-based horizontal and vertical coordinates of a number to a <see cref="Square"/> instance. A return value indicates whether the operation succeeded.
        /// </summary>
        /// <param name="x">The zero-based horizontal coordinate.</param>
        /// <param name="y">The zero-based vertical coordinate.</param>
        /// <param name="result">When this method returns, contains the square equivalent to the coordinates contained in <paramref name="x"/> and <paramref name="y"/>, if the conversion succeeded, or the default <see cref="Square"/> instance if the conversion failed. The conversion fails if the <paramref name="x"/> parameter is negative or greater than one less than the number of <see cref="Files"/> or if the <paramref name="y"/> parameter is negative or greater than one less than the number of <see cref="Ranks"/>. This parameter is treated as uninitialized.</param>
        /// <returns><see langword="true"/> if the square was created successfully; otherwise, <see langword="false"/>.</returns>
        public static bool TryCreate(int x, int y, out Square result)
        {
            if (x >= 0 && x < Files && y >= 0 && y < Ranks)
            {
                result = new Square(x, y);

                return true;
            }
            else
            {
                result = default;

                return false;
            }
        }

        /// <summary>
        /// Gets a collection of new <see cref="Square"/> instances that represent all the possible values.
        /// </summary>
        /// <returns>A collection of new <see cref="Square"/> instances.</returns>
        public static IEnumerable<Square> GetValues()
        {
            for (int y = 0; y < Ranks; y++)
            {
                for (int x = 0; x < Files; x++)
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

        /// <inheritdoc/>
        public bool Equals(Square other)
        {
            return this.X == other.X && this.Y == other.Y;
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is Square square && this.Equals(square);
        }

        /// <summary>
        /// Determines whether two specified instances of <see cref="Square"/> are equal.
        /// </summary>
        /// <param name="left">The first object to compare.</param>
        /// <param name="right">The second object to compare.</param>
        /// <returns><see langword="true"/> if <paramref name="left"/> and <paramref name="right"/> represent the same square; otherwise, <see langword="false"/>.</returns>
        public static bool operator ==(Square left, Square right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Determines whether two specified instances of <see cref="Square"/> are not equal.
        /// </summary>
        /// <param name="left">The first object to compare.</param>
        /// <param name="right">The second object to compare.</param>
        /// <returns><see langword="true"/> if <paramref name="left"/> and <paramref name="right"/> do not represent the same square; otherwise, <see langword="false"/>.</returns>
        public static bool operator !=(Square left, Square right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            HashCode result = new HashCode();

            result.Add(this.X);
            result.Add(this.Y);

            return result.ToHashCode();
        }
    }
}
