// Project Snake: MdiParent.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Snake.Application.Windows
{
    internal partial class MdiParentForm : SnakeForm
    {
        private readonly Stack<IUnexecutableCommand> _unexecutableCommands = new Stack<IUnexecutableCommand>();
        private readonly Stack<ICommand> _commands = new Stack<ICommand>();

        private int childFormNumber = 0;

        public MdiParentForm()
        {
            this.InitializeComponent();

        }

        private void Do(ICommand command)
        {
            this.RegisterExecute(command);

            this._commands.Clear();
        }

        private void Undo()
        {
            if (this._unexecutableCommands.Count > 0)
            {
                IUnexecutableCommand command = this._unexecutableCommands.Pop();

                command.Unexecute();

                this._commands.Push(command);
            }
        }

        private void Redo()
        {
            if (this._commands.Count > 0)
            {
                this.RegisterExecute(this._commands.Pop());
            }
        }

        private void RegisterExecute(ICommand command)
        {
            command.Execute();

            if (command is IUnexecutableCommand unexecutableCommand)
            {
                this._unexecutableCommands.Push(unexecutableCommand);
            }
        }

        private void OnControlClick(object sender, EventArgs e)
        {
            this.Do((sender as Control).Tag as ICommand);
        }

        private void OnUndoToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.Undo();
        }

        private void OnRedoToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.Redo();
        }

        private void OnNewControlClick(object sender, EventArgs e)
        {
            new BoardForm()
            {
                MdiParent = this
            }.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = toolbarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = statusBarToolStripMenuItem.Checked;
        }


        private void OnCascadeToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void OnTileVerticalToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void OnTileHorizontalToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void OnCloseAllToolStripMenuItemClick(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();
            }
        }

        private void OnArrangeIconsToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
    }
}
