// Project Snake: Bitboard.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;

namespace Snake
{
    internal readonly struct Bitboard : IEquatable<Bitboard>, IBitwise<Bitboard>
    {
        private readonly ulong _value;

        public bool Empty
        {
            get
            {
                return this._value == 0;
            }
        }

        private Bitboard(ulong value)
        {
            this._value = value;
        }

        public Bitboard Or(Bitboard other)
        {
            return this | other;
        }

        public static Bitboard operator |(Bitboard left, Bitboard right)
        {
            return new Bitboard(left._value | right._value);
        }

        public static Bitboard operator |(Bitboard left, Square right)
        {
            return new Bitboard(left._value | (1ul << right.Index));
        }

        public bool Equals(Bitboard other)
        {
            return this._value == other._value;
        }

        public override bool Equals(object obj)
        {
            return obj is Bitboard other && this.Equals(other);
        }

        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        public static bool operator ==(Bitboard left, Bitboard right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Bitboard left, Bitboard right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return Convert.ToString((long)this._value, 2).PadLeft(64, '0');
        }
    }
}
