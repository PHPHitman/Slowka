using System;
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
    public partial class MenuGlowne : Form
    {
        public MenuGlowne()
        {
            InitializeComponent();
        }

        private void LearnModeBtn_Click(object sender, EventArgs e)
        {
            Kategoria kategoria = new Kategoria();
            kategoria.Width = this.Width;
            kategoria.Height = this.Height;
            kategoria.StartPosition = FormStartPosition.Manual;
            kategoria.Location = new Point(this.Location.X, this.Location.Y);

            Hide();
            kategoria.ShowDialog();
            Show();
        }

        private void addWordsBtn_Click(object sender, EventArgs e)
        {
            DodajSlowko slowka = new DodajSlowko();

            slowka.Width = this.Width;
            slowka.Height = this.Height;


            slowka.StartPosition = FormStartPosition.Manual;
            slowka.Location = new Point(this.Location.X, this.Location.Y);


            Hide();
            slowka.ShowDialog();
            Show();

        }

        private void progressBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
