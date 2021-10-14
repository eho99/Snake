// Project Snake: Rank.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;

namespace Snake
{
    internal readonly partial struct Rank : IEquatable<Rank>, IFormattable
    {
        public const int Count = 8;

        public int Index { get; }

        public Rank(int value)
        {
            this.Index = value;
        }

        public bool Equals(Rank other)
        {
            return this.Index == other.Index;
        }

        public override bool Equals(object obj)
        {
            return obj is Rank other && this.Equals(other);
        }

        public override int GetHashCode()
        {
            return this.Index.GetHashCode();
        }

        public static bool operator ==(Rank left, Rank right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Rank left, Rank right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return this.ToString(format: null, formatProvider: null);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return (this.Index + 1).ToString(format, formatProvider);
        }
    }
}
