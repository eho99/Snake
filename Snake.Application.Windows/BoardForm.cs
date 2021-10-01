// Project Snake: BoardForm.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Snake.Application.Windows
{
    internal partial class BoardForm : SnakeForm
    {
        private readonly Board _board;
        private readonly IBoardFactory _boardFactory = new BoardFactory(new PieceFactory());
        private readonly PieceResourceManager _pieceResourceManager = new PieceResourceManager();

        public BoardForm()
        {
            this.InitializeComponent();

            this._board = this._boardFactory.Create(new Player(Direction.Forward, Color.Light), new Player(Direction.Backward, Color.Dark));
            Dictionary<Square, PictureBox> squares = new Dictionary<Square, PictureBox>();

            this._board.Updated += (sender, e) => this.UpdateSquare(squares[e.Value]);

            foreach (Square square in Square.GetValues())
            {
                PictureBox pictureBox = new PictureBox();
                ISupportInitialize supportInitialize = pictureBox;

                supportInitialize.BeginInit();

                pictureBox.AllowDrop = true;
                //pictureBox.Click += (sender, e) => this._selection = (Square)pictureBox.Tag;
                pictureBox.GiveFeedback += (sender, e) =>
                {
                    e.UseDefaultCursors = false;
                    Cursor.Current = Cursors.Hand;
                };
                //pictureBox.DragEnter += (sender, e) =>
                //{
                //    this._originalIimage = pictureBox.Image;
                //    pictureBox.Image = this._newImage;
                //    e.Effect = DragDropEffects.Move;
                //};
                //pictureBox.DragLeave += (sender, e) => pictureBox.Image = this._originalIimage;
                //pictureBox.DragDrop += (sender, e) => this._destination = (Square)pictureBox.Tag;
                pictureBox.BackColor = GetSquareColor(square);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Tag = square;

                this.ResizeSquare(pictureBox);
                this.UpdateSquare(pictureBox);

                supportInitialize.EndInit();

                this.boardPanel.Controls.Add(pictureBox);
                squares.Add(square, pictureBox);
            }

            this.UpdateSquare(squares[new Square(0, 0)]);
        }

        private static System.Drawing.Color GetSquareColor(Square value)
        {
            switch (value.Color)
            {
                case Color.Light: return System.Drawing.Color.Khaki;
                case Color.Dark: return System.Drawing.Color.DarkKhaki;
                default: return System.Drawing.Color.White;
            }
        }

        private void UpdateSquare(PictureBox value)
        {
            Square tag = (Square)value.Tag;

            if (value.Image is not null)
            {
                value.Image.Dispose();
            }

            if (this._board.TryGetPiece(tag, out Piece result))
            {
                value.Image = this._pieceResourceManager.GetImage(result.Player.Color, result.Symbol);
            }
            else
            {
                value.Image = null;
            }
        }

        private void ResizeSquare(Control control)
        {
            int squareWidth = this.boardPanel.Width / Square.Files;
            int squareHeight = this.boardPanel.Height / Square.Ranks;

            control.Size = new Size(squareWidth, squareHeight);

            Square tag = (Square)control.Tag;

            control.Location = new Point(tag.X * squareWidth, (Square.Ranks - tag.Y - 1) * squareHeight);
        }

        private void OnBoardPanelResize(object sender, EventArgs e)
        {
            foreach (Control control in this.boardPanel.Controls)
            {
                this.ResizeSquare(control);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            int max = Math.Max(this.Width, this.Height);

            this.Size = new Size(max, max);

            base.OnResize(e);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.components is not null)
                {
                    this.components.Dispose();
                }

                foreach (PictureBox pictureBox in this.boardPanel.Controls)
                {
                    if (pictureBox.Image is not null)
                    {
                        pictureBox.Image.Dispose();
                    }

                    pictureBox.Dispose();
                }
            }

            base.Dispose(disposing);
        }
    }
}
