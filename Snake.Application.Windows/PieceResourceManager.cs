// Project Snake: PieceResourceManager.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;

namespace Snake.Application.Windows
{
    internal class PieceResourceManager : IDisposable
    {
        private readonly PieceFactory _pieceFactory = new PieceFactory();
        private readonly ResourceManager _resourceManager = new ResourceManager(typeof(PieceResourceManager));
        private readonly Dictionary<string, Image> _images = new Dictionary<string, Image>();
        private readonly Dictionary<Piece, string> _strings;

        private bool _disposedValue;

        public PieceResourceManager()
        {
            this._strings = new Dictionary<Piece, string>(new PieceKindEqualityComparer())
            {
                { this._pieceFactory.CreateQueen(player: null), "Queen" },
                { this._pieceFactory.CreateRook(player: null), "Rook" },
                { this._pieceFactory.CreateBishop(player: null), "Bishop" },
                { this._pieceFactory.CreateKnight(player: null), "Knight" },
                { this._pieceFactory.CreatePawn(player: null), "Pawn" }
            };
        }

        public Image GetImage(Piece piece)
        {
            string key = $"{this._strings[piece]}.{piece.Player.Color}";

            if (!this._images.TryGetValue(key, out Image result))
            {
                result = this._resourceManager.GetObject(key) as Image;

                this._images.Add(key, result);
            }

            return result;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposedValue)
            {
                if (disposing)
                {
                    foreach (Image value in this._images.Values)
                    {
                        value.Dispose();
                    }
                }

                this._disposedValue = true;
            }
        }

        public void Dispose()
        {
            this.Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
