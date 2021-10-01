// Project Snake: BoardView.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Snake.Application.Windows
{
    internal class BoardView : UserControl
    {
        private readonly Dictionary<Square, SquarePictureBox> _squarePictureBoxes = new Dictionary<Square, SquarePictureBox>();

        private Board _board = new Board();
        private bool _highlighted;

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

        public BoardView()
        {
            PieceResourceManager pieceResourceManager = new PieceResourceManager();

            foreach (Square square in Square.GetValues())
            {
                SquarePictureBox squarePictureBox = new SquarePictureBox(square, pieceResourceManager);

                squarePictureBox.Click += (sender, e) =>
                {
                    foreach (SquarePictureBox value in this._squarePictureBoxes.Values)
                    {
                        value.Highlighted = false;
                    }

                    if (this._board.TryGetPiece(squarePictureBox.Value, out Piece result))
                    {
                        foreach (IMove move in result.GetMoves())
                        {
                            this._squarePictureBoxes[move.Destination].Highlighted = true;
                        }
                    }
                };

                squarePictureBox.Fit(this.Size);
                squarePictureBox.Update(this.Board);

                this.Controls.Add(squarePictureBox);
                this._squarePictureBoxes.Add(square, squarePictureBox);
            }
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
