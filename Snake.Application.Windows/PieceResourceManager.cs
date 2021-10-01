// Project Snake: PieceResourceManager.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System.Collections.Generic;
using System.Drawing;
using System.Resources;

namespace Snake.Application.Windows
{
    internal class PieceResourceManager
    {
        private readonly ResourceManager _resourceManager = new ResourceManager(typeof(PieceResourceManager));
        private readonly Dictionary<char, string> _dictionary = new Dictionary<char, string>()
        {
            { 'K', "King" },
            { 'Q', "Queen" },
            { 'R', "Rook" },
            { 'B', "Bishop" },
            { 'N', "Knight" },
            { 'p', "Pawn" }
        };

        public Image GetImage(Color color, char symbol)
        {
            return this._resourceManager.GetObject($"{this._dictionary[symbol]}.{color}") as Image;
        }
    }
}
