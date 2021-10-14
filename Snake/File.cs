// Project Snake: File.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;

namespace Snake
{
    internal readonly partial struct File : IEquatable<File>, IFormattable
    {
        private const string Alphabet = "abcdefgh";

        public const int MinValue = 0;
        public const int Count = 8;

        public int Index { get; }

        public File(int value)
        {
            this.Index = value;
        }

        public bool Equals(File other)
        {
            return this.Index == other.Index;
        }

        public override bool Equals(object obj)
        {
            return obj is File other && this.Equals(other);
        }

        public override int GetHashCode()
        {
            return this.Index.GetHashCode();
        }

        public static bool operator ==(File left, File right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(File left, File right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return this.ToString(format: null, formatProvider: null);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (this.Index >= Count)
            {
                return (this.Index + 1).ToString(format, formatProvider);
            }
            else
            {
                return Alphabet[this.Index].ToString(formatProvider);
            }
        }
    }
}
