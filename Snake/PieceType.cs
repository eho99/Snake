// Project Snake: PieceType.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;
using System.Resources;

namespace Snake
{
    internal readonly partial struct PieceType : IEquatable<PieceType>, IFormattable
    {
        private const int NoneValue = 0;
        private const int PawnValue = 6;
        private const string Alphabet = "KQRBNP";

        public const int Count = 7;
        public const int AllIndex = 0;

        private static readonly ResourceManager resourceManager = new ResourceManager(typeof(PieceType));

        public int Index { get; }

        public PieceType(int value)
        {
            this.Index = value;
        }

        public bool Equals(PieceType other)
        {
            return this.Index == other.Index;
        }

        public override bool Equals(object obj)
        {
            return obj is PieceType other && this.Equals(other);
        }

        public override int GetHashCode()
        {
            return this.Index.GetHashCode();
        }

        public static bool operator ==(PieceType left, PieceType right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(PieceType left, PieceType right)
        {
            return !(left == right);
        }

        private char GetChar()
        {
            return Alphabet[this.Index];
        }

        public override string ToString()
        {
            return this.ToString(format: null);
        }

        public string ToString(string format)
        {
            return this.ToString(format, formatProvider: null);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (this.Index >= NoneValue && this.Index < Count)
            {
                if (this.Index > NoneValue && !String.IsNullOrWhiteSpace(format))
                {
                    switch (format)
                    {
                        case "A":
                            if (this.Index == PawnValue)
                            {
                                return String.Empty;
                            }
                            else
                            {
                                return this.GetChar().ToString(formatProvider);
                            }
                        case "f": return this.GetChar().ToString(formatProvider);
                        case "F": return Char.ToUpperInvariant(this.GetChar()).ToString(formatProvider);
                    }
                }

                return resourceManager.GetString(this.Index.ToString());
            }
            else
            {
                return this.Index.ToString(format, formatProvider);
            }
        }
    }
}
