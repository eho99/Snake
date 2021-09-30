using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    /// <summary>
    /// Creates instances of the <see cref="Piece"/> class.
    /// </summary>
    public class PieceFactory : IPieceFactory
    {
        private readonly OrthogonalMoveProvider _orthogonalMoveProvider = new OrthogonalMoveProvider();
        private readonly DiagonalMoveProvider _diagonalMoveProvider = new DiagonalMoveProvider();
        private readonly LShapeMoveProvider _lShapeMoveProvider = new LShapeMoveProvider();
        private readonly AdvanceOneMoveProvider _advanceOneMoveProvider = new AdvanceOneMoveProvider();
        //private readonly InitialAdvanceTwoMoveProvider _initialAdvanceTwoMoveProvider = new InitialAdvanceTwoMoveProvider();
        //private readonly DiagonalCaptureMoveProvider _diagonalCaptureMoveProvider = new DiagonalCaptureMoveProvider();
        //private readonly EnPassantMoveProvider _enPassantMoveProvider = new enPassantMoveProvider();

		private readonly AggregateMoveProvider _rookMoveProvider;
		private readonly AggregateMoveProvider _bishopMoveProvider;
		private readonly AggregateMoveProvider _queenMoveProvider;
		private readonly AggregateMoveProvider _knightMoveProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="PieceFactory"/>.
        /// </summary>
        public PieceFactory()
        {
            this._rookMoveProvider = new AggregateMoveProvider(
                new List<IMoveProvider>()
                {
                    this._orthogonalMoveProvider
                },
                Enumerable.Empty<IMoveFilter>());

            this._bishopMoveProvider = new AggregateMoveProvider(
                new List<IMoveProvider>()
                {
                    this._diagonalMoveProvider
                },
                Enumerable.Empty<IMoveFilter>());

            this._queenMoveProvider = new AggregateMoveProvider(
                new List<IMoveProvider>()
                {
                    this._diagonalMoveProvider,
                    this._orthogonalMoveProvider
                },
                Enumerable.Empty<IMoveFilter>());

			this._knightMoveProvider = new AggregateMoveProvider(
				new List<IMoveProvider>()
				{
					this._lShapeMoveProvider
				},
				Enumerable.Empty<IMoveFilter>());
		}

        /// <inheritdoc/>
        public Piece CreateRook(Player player)
        {
            return new Piece(player, 'R', this._rookMoveProvider);
        }

        /// <inheritdoc/>
        public Piece CreateBishop(Player player)
        {
            return new Piece(player, 'B', this._bishopMoveProvider);
        }

        /// <inheritdoc/>
        public Piece CreateQueen(Player player)
        {
            return new Piece(player, 'Q', this._queenMoveProvider);
        }

		/// <inheritdoc/>
		public Piece CreateKnight(Player player)
		{
			return new Piece(player, 'N', this._knightMoveProvider);
		}
	}
=======
﻿// Project Snake: PieceFactory.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    /// <summary>
    /// Creates instances of the <see cref="Piece"/> class.
    /// </summary>
    public class PieceFactory : IPieceFactory
    {
        private readonly OrthogonalMoveProvider _orthogonalMoveProvider = new OrthogonalMoveProvider();
        private readonly DiagonalMoveProvider _diagonalMoveProvider = new DiagonalMoveProvider();
        private readonly AggregateMoveProvider _rookMoveProvider;
        private readonly AggregateMoveProvider _bishopMoveProvider;
        private readonly AggregateMoveProvider _queenMoveProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="PieceFactory"/>.
        /// </summary>
        public PieceFactory()
        {
            this._rookMoveProvider = new AggregateMoveProvider(
                new List<IMoveProvider>()
                {
                    this._orthogonalMoveProvider
                },
                Enumerable.Empty<IMoveFilter>());

            this._bishopMoveProvider = new AggregateMoveProvider(
                new List<IMoveProvider>()
                {
                    this._diagonalMoveProvider
                },
                Enumerable.Empty<IMoveFilter>());

            this._queenMoveProvider = new AggregateMoveProvider(
                new List<IMoveProvider>()
                {
                    this._diagonalMoveProvider,
                    this._orthogonalMoveProvider
                },
                Enumerable.Empty<IMoveFilter>());
        }

        /// <inheritdoc/>
        public Piece CreateRook(Player player)
        {
            return new Piece(player, 'R', this._rookMoveProvider);
        }

        /// <inheritdoc/>
        public Piece CreateBishop(Player player)
        {
            return new Piece(player, 'B', this._bishopMoveProvider);
        }

        /// <inheritdoc/>
        public Piece CreateQueen(Player player)
        {
            return new Piece(player, 'Q', this._queenMoveProvider);
        }
    }
>>>>>>> 31fb209a40331d5eb31fb5a01d9663aa1c3ed188
}
