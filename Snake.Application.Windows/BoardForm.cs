// Project Snake: BoardForm.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;
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

            this._board = this._boardFactory.Create(new Player(Direction.Forward), new Player(Direction.Backward));

            foreach (Square square in Square.GetValues())
            {
                PictureBox pictureBox = new PictureBox();
                ISupportInitialize supportInitialize = pictureBox;

                supportInitialize.BeginInit();

                pictureBox.AllowDrop = true;
                pictureBox.BackColor = GetSquareColor(square);
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox.Tag = square;

                this.ResizeSquare(pictureBox);

                supportInitialize.EndInit();

                this.boardPanel.Controls.Add(pictureBox);

                //this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.Squar_GiveFeedback);
                //this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Squar_DragEnter);
                //this.DragLeave += new System.EventHandler(this.Squar_DragLeave);
                //this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Squar_DragDrop);
                //this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Squar_MouseDown);
            }
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

        private void ResizeSquare(Control control)
        {
            int width = this.boardPanel.Width / Square.Files;
            int height = this.boardPanel.Height / Square.Ranks;

            control.Size = new Size(width, height);

            Square tag = (Square)control.Tag;

            control.Location = new Point(tag.X * width, tag.Y * height);
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
