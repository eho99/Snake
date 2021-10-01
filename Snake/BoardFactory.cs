// Project Snake: BoardFactory.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

namespace Snake
{
    /// <summary>
    /// An <see cref="IBoardFactory"/> that creates instances of the <see cref="Board"/> class.
    /// </summary>
    public class BoardFactory : IBoardFactory
    {
        private readonly IPieceFactory _pieceFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="BoardFactory"/> class.
        /// </summary>
        public BoardFactory(IPieceFactory pieceFactory)
        {
            this._pieceFactory = pieceFactory;
        }

        /// <inheritdoc/>
        public Board Create(Player first, Player second)
        {
            Board result = new Board();

            for (char file = 'a'; file <= 'h'; file++)
            {
                result.Insert(this._pieceFactory.CreatePawn(first), new Square(file, 2));
            }

            for (char file = 'a'; file <= 'h'; file++)
            {
                result.Insert(this._pieceFactory.CreatePawn(second), new Square(file, 7));
            }

            result.Insert(this._pieceFactory.CreateRook(first), new Square('a', 1));
            result.Insert(this._pieceFactory.CreateRook(first), new Square('h', 1));

            result.Insert(this._pieceFactory.CreateRook(second), new Square('a', 8));
            result.Insert(this._pieceFactory.CreateRook(second), new Square('h', 8));

            return result;
        }
    }
}
