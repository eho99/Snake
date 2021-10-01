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

        private Color _highlight;

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Color Highlight
        {
            get => this._highlight;
            set
            {
                this._highlight = value;

                this.BackColor = this.GetTransparentBackColor();
            }
        }

        public SquarePictureBox(Square value, PieceResourceManager pieceResourceManager)
        {
            this.Value = value;
            this._pieceResourceManager = pieceResourceManager;

            ISupportInitialize supportInitialize = this;

            supportInitialize.BeginInit();

            this.AllowDrop = true;
            this.BackColor = this.GetTransparentBackColor();
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

        private System.Drawing.Color GetTransparentBackColor()
        {
            System.Drawing.Color getBackColor()
            {
                switch (this._highlight)
                {
                    case Color.Light:
                        switch (this.Value.Color)
                        {
                            case Color.Light: return System.Drawing.Color.Goldenrod;
                            case Color.Dark: return System.Drawing.Color.DarkGoldenrod;
                            default: return System.Drawing.Color.White;
                        }

                    case Color.Dark:
                        switch (this.Value.Color)
                        {
                            case Color.Light: return System.Drawing.Color.Green;
                            case Color.Dark: return System.Drawing.Color.DarkGreen;
                            default: return System.Drawing.Color.Black;
                        }

                    default:
                        switch (this.Value.Color)
                        {
                            case Color.Light: return System.Drawing.Color.Khaki;
                            case Color.Dark: return System.Drawing.Color.DarkKhaki;
                            default: return System.Drawing.Color.Transparent;
                        }
                }
            }

            return System.Drawing.Color.FromArgb(192, getBackColor());
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
