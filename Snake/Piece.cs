// Project Snake: Piece.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;

namespace Snake
{
    internal readonly partial struct Piece : IEquatable<Piece>, IFormattable
    {
        public int Index { get; }

        public Player Owner
        {
            get
            {
                return new Player(this.Index >> 3 == 0);
            }
        }

        public PieceType Type
        {
            get
            {
                return new PieceType(this.Index & 7);
            }
        }

        public Piece(Player owner, PieceType type)
        {
            this.Index = type.Index | (owner.Index << 3);
        }

        public bool Equals(Piece other)
        {
            return this.Index == other.Index;
        }

        public override bool Equals(object obj)
        {
            return obj is Piece other && this.Equals(other);
        }

        public override int GetHashCode()
        {
            return this.Index.GetHashCode();
        }

        public static bool operator ==(Piece left, Piece right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Piece left, Piece right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return this.ToString(format: null, formatProvider: null);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return String.Format(formatProvider, "{0} {1}", this.Owner, this.Type);
        }
    }
}
