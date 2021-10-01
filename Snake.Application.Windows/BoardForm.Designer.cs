// Project Snake: BoardForm.Designer.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.


namespace Snake.Application.Windows
{
    partial class BoardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Snake.Board board1 = new Snake.Board();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardForm));
            this.boardView1 = new Snake.Application.Windows.BoardView();
            this.SuspendLayout();
            // 
            // boardView1
            // 
            this.boardView1.Board = board1;
            resources.ApplyResources(this.boardView1, "boardView1");
            this.boardView1.Name = "boardView1";
            // 
            // BoardForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.boardView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "BoardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private BoardView boardView1;
    }
}
