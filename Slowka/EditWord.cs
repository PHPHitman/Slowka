using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Words.WordClass;

namespace Slowka.WordClass
{
    public partial class EditWord : Form
    {
        public EditWord()
        {
            InitializeComponent();
        }
        static string connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private string choosenLang = "Angielski";
        private string selectedWordID;
        private string nauczone;

        private string xword;
        private string translate;
        private string choosenCat;
        private string learned;

        Words.WordClass.Words ew = new Words.WordClass.Words();

        /// <summary>
        /// Load words from database and insert to grid view
        /// </summary>
        public void LoadWords()
        {
            string word = searchWord.Text;


            SqlConnection connection = new SqlConnection(connstring);
            SqlDataAdapter sqldata = new SqlDataAdapter("SELECT slowkoID, Slowko, Tlumaczenie, Kategoria, Nauczone FROM slowka WHERE Jezyk=@lang AND (Slowko LIKE '%" + word + "%' OR Tlumaczenie LIKE '% " + word + "%')", connection);

            sqldata.SelectCommand.Parameters.AddWithValue("@lang", choosenLang);

            DataTable datatable = new DataTable();
            connection.Open();
            sqldata.Fill(datatable);
            searchGridView.DataSource = datatable;

            this.searchGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.searchGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.searchGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.searchGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.searchGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        /// <summary>
        /// Update database with changed word
        /// </summary>
        /// <param name="ew">Word object with changed values</param>
        public void saveChangedWord(Words.WordClass.Words ew)
        {
            SqlConnection connection = new SqlConnection(connstring);

            //Update database
            string sql = "UPDATE Slowka SET Slowko=@Slowko, Tlumaczenie=@Tlumaczenie, Kategoria=@Kategoria, Nauczone=@Nauczone WHERE SlowkoID=@slowkoID";

            //SQL command
            SqlCommand command = new SqlCommand(sql, connection);
            //Parameters
            command.Parameters.AddWithValue("@Slowko", ew.Slowko);
            command.Parameters.AddWithValue("@Tlumaczenie", ew.Tlumaczenie);
            command.Parameters.AddWithValue("@Kategoria", ew.Kategoria);
            command.Parameters.AddWithValue("SlowkoID", ew.SlowkoID);
            command.Parameters.AddWithValue("@Nauczone", ew.Nauczone);


            //Open database connection
            connection.Open();
            int counter = command.ExecuteNonQuery();
            //if query is success
            if (counter > 0)
            {
                MessageBox.Show("Słówko zostało zmienione!");
            }
            else
            {
                MessageBox.Show("Wystąpił błąd!");
            }
            connection.Close();
        }

        /// <summary>
        /// Check if user inserted valid data
        /// If error occur show error message under text fields
        /// If no errors occured save word
        /// </summary>
        public void checkDataIsValid()
        {
            xword = wordBox.Text;
            translate = translateBox.Text;
            choosenCat = categoryComboBox.Text;

            if (xword == "")
            {
                wordError.Text = "Wprowadź słówko!";
            }
            else if (translate == "")
            {
                translateError.Text = "Wprowadź tłumaczenie!";
            }

            else if (choosenCat == null)
            {
                categoryError.Text = "Wybierz kategorię!";
            }
            else
            {
                ew.SlowkoID = int.Parse(selectedWordID);
                ew.Slowko = xword;
                ew.Tlumaczenie = translate;
                ew.Kategoria = choosenCat;
                ew.Nauczone = learned;

                saveChangedWord(ew);
                LoadWords();
            }



        }


        /// <summary>
        /// Insert values from clicked row into text fields to edit
        /// </summary>
        /// <param name="row">Number of clicked row in data grid view</param>
        public void insertWordToFields(int row)
        {

            //Load data to fields
            selectedWordID = searchGridView.Rows[row].Cells[0].Value.ToString();
            wordBox.Text = searchGridView.Rows[row].Cells[1].Value.ToString();
            translateBox.Text = searchGridView.Rows[row].Cells[2].Value.ToString();
            categoryComboBox.Text = searchGridView.Rows[row].Cells[3].Value.ToString();
            nauczone = searchGridView.Rows[row].Cells[4].Value.ToString();


            if (nauczone == "Tak")
            {
                learnedBtn.Checked = true;
            }
            else
            {
                unlearnedBtn.Checked = true;
            }
        }

        /// <summary>
        /// Delete word from database
        /// </summary>
        /// <param name="ew">Selected word</param>
        private void DeleteWord(Words.WordClass.Words ew)
        {
            ew.SlowkoID = int.Parse(selectedWordID);

            SqlConnection connection = new SqlConnection(connstring);

            string sql = "Delete FROM Slowka WHERE SlowkoID=@slowkoID";

            //Sql command
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@SlowkoID", ew.SlowkoID);
            //Open connection
            connection.Open();
            int counter = command.ExecuteNonQuery();

            if (counter > 0)
            {
                MessageBox.Show("Słówko zostało usunięte!");
            }
            else
            {
                MessageBox.Show("Wystąpił błąd!");

            }
            connection.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void EditWord_Load(object sender, EventArgs e)
        {
            LoadWords();
        }

        private void searchWord_TextChanged(object sender, EventArgs e)
        {
            LoadWords();
        }

        private void englishBtn_CheckedChanged(object sender, EventArgs e)
        {
            choosenLang = "Angielski";
            LoadWords();
        }

        private void germanBtn_CheckedChanged(object sender, EventArgs e)
        {
            choosenLang = "Niemiecki";
            LoadWords();
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            checkDataIsValid();
        }

        private void searchGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int row = e.RowIndex;
                insertWordToFields(row);
            }
        }

        private void learnedBtn_CheckedChanged(object sender, EventArgs e)
        {
            learned = "Tak";
        }

        private void searchGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int row = e.RowIndex;
                insertWordToFields(row);

            }
        }

        private void wordBox_TextChanged(object sender, EventArgs e)
        {
            wordError.Text = "";
        }

        private void translateBox_TextChanged(object sender, EventArgs e)
        {
            translateError.Text = "";
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryError.Text = "";
        }

        private void unlearnedBtn_CheckedChanged(object sender, EventArgs e)
        {
            learned = "Nie";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteWord(ew);
            LoadWords();
        }
    }
}
