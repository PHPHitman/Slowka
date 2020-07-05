﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slowka
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void LearnModeBtn_Click(object sender, EventArgs e)
        {
            Category Category = new Category();
            Category.Width = this.Width;
            Category.Height = this.Height;
            Category.StartPosition = FormStartPosition.Manual;
            Category.Location = new Point(this.Location.X, this.Location.Y);

            Hide();
            Category.ShowDialog();
            Show();
        }

        private void addWordsBtn_Click(object sender, EventArgs e)
        {
            AddNewWord addWords = new AddNewWord();

            addWords.Width = this.Width;
            addWords.Height = this.Height;


            addWords.StartPosition = FormStartPosition.Manual;
            addWords.Location = new Point(this.Location.X, this.Location.Y);


            Hide();
            addWords.ShowDialog();
            Show();
        }
    }
}