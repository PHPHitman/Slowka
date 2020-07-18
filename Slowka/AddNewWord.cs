using Words.WordClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Data.SqlClient;
using System.Configuration;

namespace Slowka
{
    public partial class AddNewWord : Form
    {

        private string language="Angielski";
        
        public AddNewWord()
        {
            InitializeComponent();
        }
        EnglishWords s = new EnglishWords();

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }



   

        private void AddNewWord_Load(object sender, EventArgs e)
        {
            
            //Load data in Data GridView using method
            DataTable dt = s.Select(language);
            dataGridView1.DataSource = dt;

        }
        //Method to clear all fields
        public void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            searchBox.Text = "";
            comboBox1.Text = "";
            idTextBox.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void wordsEnglishBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        

        }

        private void wordsEnglishBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
   

        }

        private void wordsEnglishDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get data from Data Grid and load to text fields

            //Identifying clicked row
            int rowIndex = e.RowIndex;
            //Load data to fields
            idTextBox.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
 
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

  

        private void button3_Click(object sender, EventArgs e)
        {

        }
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            //Get value from text box
            string word = searchBox.Text;
            

            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM slowka WHERE Jezyk=@lang AND (Slowko LIKE '%" + word + "%' OR Tlumaczenie LIKE '% " +word + "%')",conn); 

            sda.SelectCommand.Parameters.AddWithValue("@lang", language);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            ////Get data from textboxes
            //s.SlowkoID = int.Parse(textBox1.Text);
            s.SlowkoID = int.Parse(idTextBox.Text);
            s.Slowko = textBox1.Text;
            s.Tlumaczenie = textBox2.Text;
            s.Kategoria = comboBox1.Text;

            //Update date in database
            bool success = s.Update(s);
            if (success == true)
            {
                MessageBox.Show("Słówko zostało zaktualizowane!");
            }
            else
            {
                MessageBox.Show("Wystąpił błąd, spróbuj ponownie");
            }
            //Load data in Data GridView using method
            DataTable dt = s.Select(language);
            dataGridView1.DataSource = dt;
            //Clear text fields after updated
            Clear();
        }

        private void addWordBtn_Click(object sender, EventArgs e)
        {
        
            //Get value from input fields
            s.Slowko = textBox1.Text;
            s.Tlumaczenie = textBox2.Text;
            s.Kategoria = comboBox1.Text;
            s.Jezyk = language;
       

            //Insert data to database
            bool success = s.Insert(s);
            if (success == true)
            {
                //Success message
                MessageBox.Show("Dodano nowe słówko");
                //Emptying fields
                Clear();
            }
            else
            {
                //Fail message
                MessageBox.Show("Niepowodzenie. Spróbuj ponownie");
            }

            //Load data in Data GridView using method
            DataTable dt = s.Select(language);
            dataGridView1.DataSource = dt;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //Get Data from textfields
            s.SlowkoID = Convert.ToInt32(idTextBox.Text);
            bool success = s.Delete(s);
            if (success == true)
            {
                MessageBox.Show("Słówko usunięte!");

                //Refresh data grid view
                DataTable dt = s.Select(language);
                dataGridView1.DataSource = dt;
                //Clear text fields
                Clear();
            }
            else
            {
                MessageBox.Show("Wystąpił błąd, spróbuj ponownie");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //Clear text fields
            Clear();
        }

        private void radioBtnEnglish_CheckedChanged(object sender, EventArgs e)
        {
            language = radioBtnEnglish.Text.ToString();
            DataTable dt = s.Select(language);
            dataGridView1.DataSource = dt;
            Clear();
        }

        private void radioBtnGerman_CheckedChanged(object sender, EventArgs e)
        {
            language = radioBtnGerman.Text.ToString();
            DataTable dt = s.Select(language);
            dataGridView1.DataSource = dt;
            Clear();
        }

        private void statLearned_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
