using System.Collections.Generic;

namespace Snake
{
    /// <summary>
    /// Creates instances of the <see cref="Piece"/> class.
    /// </summary>
    public class PieceFactory : IPieceFactory
    {
        private readonly AggregateMoveProvider _rookMoveProvider = new AggregateMoveProvider(
            new List<IMoveProvider>()
            {
                new OrthogonalMoveProvider()
            },
            new List<IMoveFilter>());

        /// <inheritdoc/>
        public Piece CreateRook(Player player)
        {
            return new Piece(player, 'R', this._rookMoveProvider);
        }
    }
}
