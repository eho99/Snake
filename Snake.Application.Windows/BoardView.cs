// Project Snake: BoardView.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Snake.Application.Windows
{
    internal class BoardView : UserControl, IBoardViewContext
    {
        private readonly Dictionary<Square, SquarePictureBox> _squarePictureBoxes = new Dictionary<Square, SquarePictureBox>();
        private readonly InitialBoardViewState _intialState = new InitialBoardViewState();

        private Board _board = new Board();
        private IBoardViewState _state;

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Board Board
        {
            get => this._board;
            set
            {
                if (this.Board is not null)
                {
                    this.Board.Updated -= this.OnBoardUpdated;
                }

                value.Updated += this.OnBoardUpdated;

                foreach (SquarePictureBox squarePictureBox in this._squarePictureBoxes.Values)
                {
                    squarePictureBox.Update(value);
                }

                this._board = value;
            }
        }

        public void SetState(IBoardViewState value)
        {
            this._state = value;
        }

        public BoardView()
        {
            PieceResourceManager pieceResourceManager = new PieceResourceManager();

            foreach (Square square in Square.GetValues())
            {
                SquarePictureBox squarePictureBox = new SquarePictureBox(square, pieceResourceManager);

                squarePictureBox.Click += (sender, e) => this.Select(squarePictureBox.Value);

                squarePictureBox.Fit(this.Size);
                squarePictureBox.Update(this.Board);

                this.Controls.Add(squarePictureBox);
                this._squarePictureBoxes.Add(square, squarePictureBox);
            }

            this.SetState(this._intialState);
        }

        public void Select(Square square)
        {
            this._state.Select(square, context: this);
        }

        void IBoardViewContext.Reset()
        {
            foreach (SquarePictureBox value in this._squarePictureBoxes.Values)
            {
                value.Highlight = Color.None;
            }

            this.SetState(this._intialState);
        }

        void IBoardViewContext.Highlight(Square square)
        {
            this._squarePictureBoxes[square].Highlight = Color.Light;
        }

        void IBoardViewContext.Unhiglight(Square square)
        {
            this._squarePictureBoxes[square].Highlight = Color.None;
        }

        void IBoardViewContext.Present(IMove move)
        {
            this._squarePictureBoxes[move.Destination].Highlight = Color.Dark;
        }

        private void OnBoardUpdated(object sender, SquareEventArgs e)
        {
            this._squarePictureBoxes[e.Value].Update(this.Board);
        }

        protected override void OnResize(EventArgs e)
        {
            foreach (SquarePictureBox value in this._squarePictureBoxes.Values)
            {
                value.Fit(this.Size);
            }

            base.OnResize(e);
        }

        protected override void Dispose(bool disposing)
        {
            foreach (SquarePictureBox value in this._squarePictureBoxes.Values)
            {
                value.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
