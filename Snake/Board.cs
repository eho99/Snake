// Project Snake: Board.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;

namespace Snake
{
    internal class Board
    {
        //private const int Sixteen = 16;

        //private readonly int[] _pieceCounts = new int[Sixteen];
        private readonly int[] _indices = new int[Square.Count];
        private readonly Piece[] _pieces = new Piece[Square.Count];
        //private readonly Square[,] _squares = new Square[Square.Count, Sixteen];

        /// <summary>
        /// An array of bitboards that represents the positions of each piece by its type, indexed by the <see cref="PieceType.Index"/> property. The bitboard at the index given by the <see cref="PieceType.AllIndex"/> field contains the positions of all pieces.
        /// </summary>
        private readonly Bitboard[] _pieceBitboards = new Bitboard[PieceType.Count];

        /// <summary>
        /// An array of biboards that represents the positons of each piece by its owner, indexed by the <see cref="Player.Index"/> property.
        /// </summary>
        private readonly Bitboard[] _playerBitboards = new Bitboard[Player.Count];

        public Piece this[Square square]
        {
            get
            {
                return this._pieces[square.Index];
            }
        }

        public void Clear()
        {
            //Array.Clear(this._pieceCounts, index: 0, this._pieceCounts.Length);
            Array.Clear(this._indices, index: 0, this._indices.Length);
            Array.Clear(this._pieces, index: 0, this._pieces.Length);
            //Array.Clear(this._squares, index: 0, this._squares.Length);
            Array.Clear(this._playerBitboards, index: 0, this._playerBitboards.Length);
            Array.Clear(this._pieceBitboards, index: 0, this._pieceBitboards.Length);
        }

        public void Insert(Square square, Piece piece)
        {
            this._pieces[square.Index] = piece;

            this._pieceBitboards[PieceType.AllIndex] |= square;
            this._pieceBitboards[piece.Type.Index] |= square;

            this._playerBitboards[piece.Owner.Index] |= square;

            //_index[sq.AsInt()] = _pieceCount[pc.AsInt()]++;
            //_pieceList[pc.AsInt()][_index[sq.AsInt()]] = sq;
            //_pieceCount[PieceTypes.AllPieces.MakePiece(pc.ColorOf()).AsInt()]++;
        }
    }
}
