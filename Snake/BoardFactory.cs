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

            for (char file = 'a'; file < 'h'; file++)
            {
                result[new Square(file, 2)] = this._pieceFactory.CreatePawn(first);
            }

            for (char file = 'a'; file < 'h'; file++)
            {
                result[new Square(file, 7)] = this._pieceFactory.CreatePawn(second);
            }

            result[new Square('a', 1)] = this._pieceFactory.CreateRook(first);
            result[new Square('h', 1)] = this._pieceFactory.CreateRook(first);

            result[new Square('a', 8)] = this._pieceFactory.CreateRook(second);
            result[new Square('h', 8)] = this._pieceFactory.CreateRook(second);

            return result;
        }
    }
}
