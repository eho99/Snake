// Project Snake: Player.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;
using System.Resources;

namespace Snake
{
    internal readonly struct Player : IEquatable<Player>
    {
        public const int Count = 2;

        private static readonly ResourceManager resourceManager = new ResourceManager(typeof(Player));

        private readonly bool _white;

        public int Index
        {
            get
            {
                if (this._white)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public Player(bool white)
        {
            this._white = white;
        }

        public bool Equals(Player other)
        {
            return this._white == other._white;
        }

        public override bool Equals(object obj)
        {
            return obj is Player other && this.Equals(other);
        }

        public override int GetHashCode()
        {
            return this._white.GetHashCode();
        }

        public static bool operator ==(Player left, Player right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Player left, Player right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return resourceManager.GetString(this._white.ToString());
        }
    }
}
