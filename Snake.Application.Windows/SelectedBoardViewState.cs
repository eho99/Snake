// Project Snake: BoardViewContext.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Snake.Application.Windows
{
    internal class SelectedBoardViewState : IBoardViewState
    {
        private readonly Piece _piece;
        private readonly IEnumerable<IMove> _moves;

        public SelectedBoardViewState(Piece piece, IEnumerable<IMove> moves)
        {
            this._piece = piece;
            this._moves = moves;
        }

        public void Select(Square square, IBoardViewContext context)
        {
            if (square == this._piece.Square)
            {
                context.Reset();
            }
            else
            {
                try
                {
                    IMove move = this._moves.SingleOrDefault(x => x.Destination == square);

                    if (move is null)
                    {
                        context.Reset();
                        context.Select(square);
                    }
                    else
                    {
                        move.Execute(context.Board);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    context.Reset();
                    context.Select(square);
                }
            }
        }
    }
}
