// Project Snake: SquarePictureBox.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Snake.Application.Windows
{
    internal class SquarePictureBox : PictureBox
    {
        private readonly PieceResourceManager _pieceResourceManager;

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Square Value { get; }

        private bool _highlighted;

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool Highlighted
        {
            get => this._highlighted;
            set
            {
                this._highlighted = value;

                this.BackColor = this.GetBackColor();
            }
        }

        public SquarePictureBox(Square value, PieceResourceManager pieceResourceManager)
        {
            this.Value = value;
            this._pieceResourceManager = pieceResourceManager;

            ISupportInitialize supportInitialize = this;

            supportInitialize.BeginInit();

            this.AllowDrop = true;
            this.BackColor = this.GetBackColor();
            this.SizeMode = PictureBoxSizeMode.StretchImage;

            supportInitialize.EndInit();
        }

        public void Fit(Size size)
        {
            int squareWidth = size.Width / Square.Files;
            int squareHeight = size.Height / Square.Ranks;

            this.Size = new Size(squareWidth, squareHeight);

            Square square = this.Value;

            this.Location = new Point(square.X * squareWidth, (Square.Ranks - square.Y - 1) * squareHeight);
        }

        public void Update(Board board)
        {
            if (this.Image is not null)
            {
                this.Image.Dispose();
            }

            if (board.TryGetPiece(this.Value, out Piece result))
            {
                this.Image = this._pieceResourceManager.GetImage(result.Player.Color, result.Symbol);
            }
            else
            {
                this.Image = null;
            }
        }

        private System.Drawing.Color GetBackColor()
        {
            System.Drawing.Color result;

            switch (this.Value.Color)
            {
                case Color.Light:
                    result = System.Drawing.Color.Khaki;
                    break;

                case Color.Dark:
                    result = System.Drawing.Color.DarkKhaki;
                    break;

                default: 
                    result = System.Drawing.Color.White;
                    break;
            }

            if (!this._highlighted)
            {
                result = System.Drawing.Color.FromArgb(128, result);
            }

            return result;
        }

        protected override void OnGiveFeedback(GiveFeedbackEventArgs gfbevent)
        {
            gfbevent.UseDefaultCursors = false;

            Cursor.Current = Cursors.Hand;

            base.OnGiveFeedback(gfbevent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.Image is not null)
            {
                this.Image.Dispose();
                this.Image = null;
            }

            base.Dispose(disposing);
        }
    }
}
