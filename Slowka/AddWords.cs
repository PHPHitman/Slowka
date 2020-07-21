using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Slowka.WordClass
{
    public partial class AddWords : Form
    {
        public AddWords()
        {
            InitializeComponent();
        }
        static string connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private string xword;
        private string translate;
        private string choosenLang = "Angielski";
        private string choosenCat;

        private string typedWord;

        Words.WordClass.Words ew = new Words.WordClass.Words();
        /// <summary>
        /// Check if word exists
        /// </summary>
        /// <param name="word">Inserted word</param>
        public void CheckIfWordExist(string word)
        {

            string sql;
            SqlConnection sqlconn = new SqlConnection(connstring);

            sql = "SELECT COUNT(*)  FROM slowka WHERE Jezyk=@lang AND Slowko= @slowko";

            SqlCommand command = new SqlCommand(sql, sqlconn);

            command.Parameters.AddWithValue("@lang", choosenLang);
            command.Parameters.AddWithValue("@slowko", word);
            sqlconn.Open();



            int count = (int)command.ExecuteScalar();


            if (count > 0)
            {
                wordError.Text = "Słówko już istnieje! Wprowadź inne.";
                wordTextBox.Focus();
                wordTextBox.ForeColor = Color.Red;
            }
            else
            {
                wordError.Text = "";
                xword = wordTextBox.Text;
            }
            sqlconn.Close();



        }


        /// <summary>
        /// Save inserted word
        /// </summary>
        /// <param name="ewx">Created word object with assigned values</param>
        public void SaveWord(Words.WordClass.Words ewx)
        {
            SqlConnection connection = new SqlConnection(connstring);



            string sql = "INSERT INTO Slowka (Slowko, Tlumaczenie, Kategoria, Jezyk, Nauczone, Bledne, Poprawne) VALUES(@Slowko, @Tlumaczenie, @Kategoria, @Jezyk, 'Nie', 0, 0)";

            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Slowko", ewx.Slowko);
            command.Parameters.AddWithValue("@Tlumaczenie", ewx.Tlumaczenie);
            command.Parameters.AddWithValue("@Kategoria", ewx.Kategoria);
            command.Parameters.AddWithValue("@Jezyk", ewx.Jezyk);

            connection.Open();

            int count = command.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Dodano słówko!");
            }
            else
            {
                MessageBox.Show("Wystąpił błąd, spróbuj ponownie!");
            }

        }


        /// <summary>
        /// Clear text fields and assign default values to variables
        /// </summary>
        public void ClearTextFields()
        {
            wordTextBox.Text = "";
            translateTextBox.Text = "";
            comboBoxCategory.Text = "";
            xword = "";
            translate = "";
            choosenLang = "Angielski";
            choosenCat = "";

        }
        private void wordTextBox_TextChanged(object sender, EventArgs e)
        {
            wordError.Text = "";
            wordTextBox.ForeColor = Color.Black;
        }

        private void translateTextBox_TextChanged(object sender, EventArgs e)
        {
            translateError.Text = "";
            translate = translateTextBox.Text;
        }

        private void wordTextBox_Leave(object sender, EventArgs e)
        {
            typedWord = wordTextBox.Text;
            CheckIfWordExist(typedWord);
        }

        private void editWordsBtn_Click(object sender, EventArgs e)
        {
            EditWord editWord = new EditWord();

            editWord.Width = this.Width;
            editWord.Height = this.Height;


            editWord.StartPosition = FormStartPosition.Manual;
            editWord.Location = new Point(this.Location.X, this.Location.Y);


            Hide();
            editWord.ShowDialog();
            Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void addWordBtn_Click(object sender, EventArgs e)
        {
            if (xword == "" || xword==null)
            {
                wordError.Text = "Wprowadź słówko!";
            }
            else if (translate == "" || translate==null)
            {
                translateError.Text = "Wprowadź tłumaczenie!";
            }
            else if (choosenLang == "" )
            {
                languageError.Text = "Wybierz Język!";
            }
            else if (choosenCat == null)
            {
                categoryError.Text = "Wybierz kategorię!";
            }
            else
            {
                ew.Slowko = xword;
                ew.Tlumaczenie = translate;
                ew.Jezyk = choosenLang;
                ew.Kategoria = choosenCat;

                SaveWord(ew);
                ClearTextFields();
            }


        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryError.Text = "";
            choosenCat = comboBoxCategory.Text;
        }
    }
   }

