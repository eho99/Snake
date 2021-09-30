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
        private readonly AggregateMoveProvider _rookMoveProvider;

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
        }

        /// <inheritdoc/>
        public Piece CreateRook(Player player)
        {
            return new Piece(player, 'R', this._rookMoveProvider);
        }
    }
}
