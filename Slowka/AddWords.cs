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

        UserWords ewx= new UserWords();
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
        /// Save word into database
        /// </summary>
        /// <param name="ewx">Object with assigned values</param>
        /// <param name="connstring">Connectionstring</param>
        /// <returns></returns>
        public bool SaveWord(UserWords ewx, string connstring)
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
                return true;
            }
            else
            {
                MessageBox.Show("Wystąpił błąd, spróbuj ponownie!");
                return false;
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

        /// <summary>
        /// Check if fields are empty
        /// If empty show message under text field
        /// </summary>
        /// <param name="xword">Inserted word</param>
        /// <param name="translate">Inserted translate</param>
        /// <param name="choosenLang">Choosen language</param>
        /// <param name="choosenCat">Choosen category</param>
        /// <returns></returns>
        public bool CheckAreFieldsEmpty(string xword, string translate, string choosenLang, string choosenCat)
        {
            
            if (xword == "" || xword == null)
            {
                wordError.Text = "Wprowadź słówko!";
                return  true;
            }
            else if (translate == "" || translate == null)
            {
                translateError.Text = "Wprowadź tłumaczenie!";
                return  true;

            }
            else if (choosenLang == "")
            {
                languageError.Text = "Wybierz Język!";
                return true;
            }
            else if (choosenCat == null)
            {
                categoryError.Text = "Wybierz kategorię!";
                return  true;
            }
            else
            {
                return  false;
            }
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
            if (CheckAreFieldsEmpty(xword, translate, choosenLang, choosenCat)==false)
            {
                {
                    ewx.Slowko = xword;
                    ewx.Tlumaczenie = translate;
                    ewx.Jezyk = choosenLang;
                    ewx.Kategoria = choosenCat;

                    SaveWord(ewx, connstring);
                    ClearTextFields();
                }
            }


        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryError.Text = "";
            choosenCat = comboBoxCategory.Text;
        }
    }
   }

