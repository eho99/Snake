// Project Snake: BoardForm.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;
using System.Collections.Generic;
using System.Drawing;

namespace Snake.Application.Windows
{
    internal partial class BoardForm : SnakeForm
    {
        private readonly IBoardFactory _boardFactory = new BoardFactory(new PieceFactory());

        public BoardForm()
        {
            this.InitializeComponent();

            this.boardView1.Board = this._boardFactory.Create(new Player(Direction.Forward, Color.Light), new Player(Direction.Backward, Color.Dark));
        }

        protected override void OnResize(EventArgs e)
        {
            int max = Math.Max(this.Width, this.Height);

            this.Size = new Size(max, max);

            base.OnResize(e);
        }
    }
}
