// Project Snake: Square.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;

namespace Snake
{
    internal readonly partial struct Square : IEquatable<Square>, IFormattable
    {
        public const int Count = 64;

        public int Index { get; }

        public Rank Rank
        {
            get
            {
                return new Rank(this.Index >> 3);
            }
        }

        public File File
        {
            get
            {
                return new File(this.Index & 7);
            }
        }

        public Square(File file, Rank rank)
        {
            this.Index = file.Index | (rank.Index << 3);
        }

        public bool Equals(Square other)
        {
            return this.Index == other.Index;
        }

        public override bool Equals(object obj)
        {
            return obj is Square other && this.Equals(other);
        }

        public override int GetHashCode()
        {
            return this.Index.GetHashCode();
        }

        public static bool operator ==(Square left, Square right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Square left, Square right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return this.ToString(format: null, formatProvider: null);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return String.Format(formatProvider, "{0}{1}", this.File, this.Rank);
        }
    }
}
