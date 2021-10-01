// Project Snake: SnakeForm.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;
using System.Reflection;
using System.Windows.Forms;

namespace Snake.Application.Windows
{
    internal class SnakeForm : Form
    {
        private readonly string _assemblyTitle;

        private string _text;
        public override string Text
        {
            get => this._text;
            set
            {
                this._text = value;

                if (String.IsNullOrWhiteSpace(value))
                {
                    base.Text = this._assemblyTitle;
                }
                else
                {
                    base.Text = $"{this._assemblyTitle} - {value}";
                }
            }
        }

        protected SnakeForm()
        {
            AssemblyTitleAttribute assemblyTitleAttribute = typeof(SnakeForm).Assembly.GetCustomAttribute<AssemblyTitleAttribute>();

            if (assemblyTitleAttribute is not null)
            {
                this._assemblyTitle = assemblyTitleAttribute.Title;
            }
        }
    }
}
