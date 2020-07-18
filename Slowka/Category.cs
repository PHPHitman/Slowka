using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Words.WordClass;

namespace Slowka
{
    public partial class Category : Form
    {

        public static string language ="";
        public static string category="";

  
        public Category()
        {
            InitializeComponent();
        }
        
        

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            language= languageBox.Text;
            category = categoryBox.Text;

            ShowWord showWord = new ShowWord();

            showWord.Width = this.Width;
            showWord.Height = this.Height;


            showWord.StartPosition = FormStartPosition.Manual;
            showWord.Location = new Point(this.Location.X, this.Location.Y);


            Hide();
            showWord.ShowDialog();
            Show();
        }

        private void languageBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
