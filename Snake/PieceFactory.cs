// Project Snake: PieceFactory.cs
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
}