// Project Snake: AggregateMoveProvider.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System.Collections.Generic;

namespace Snake
{
    internal class AggregateMoveProvider : IMoveProvider
    {
        private readonly IEnumerable<IMoveProvider> _moveProviders;
        private readonly IEnumerable<IMoveFilter> _moveFilters;

        public AggregateMoveProvider(IEnumerable<IMoveProvider> moveProviders, IEnumerable<IMoveFilter> moveFilters)
        {
            this._moveProviders = moveProviders;
            this._moveFilters = moveFilters;
        }

        public IEnumerable<IMove> GetMoves(Piece piece)
        {
            HashSet<IMove> results = new HashSet<IMove>();

            foreach (IMoveProvider moveProvider in this._moveProviders)
            {
                foreach (IMove move in moveProvider.GetMoves(piece))
                {
                    results.Add(move);
                }
            }

            foreach (IMoveFilter moveFilter in this._moveFilters)
            {
                moveFilter.Filter(results);
            }

            return results;
        }
    }
}
