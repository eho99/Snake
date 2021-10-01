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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardForm));
            this.boardPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // boardPanel
            // 
            resources.ApplyResources(this.boardPanel, "boardPanel");
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Resize += new System.EventHandler(this.OnBoardPanelResize);
            // 
            // BoardForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.boardPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "BoardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel boardPanel;
    }
}
