using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Slowka
{
    public partial class Statistics : Form
    {
        int nauczone;
        int nienauczone;
        int wszystkie;
        string choosenLang="Angielski";
        string choosenCat = "";

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public Statistics()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Load words statistics and display
        /// </summary>
        public void LoadStats()
        {
            nauczone = 0;
            nienauczone = 0;
            wszystkie = 0;
            label2.Text = "0";
            label4.Text = "0";
            label6.Text = "0";

            SqlConnection conn = new SqlConnection(myconnstring);


            string sql;
            string sql1;
            string sql2;

            //Load learned ammount 
            if (choosenCat == "Wszystkie")
            {
                sql = "Select slowkoID from slowka WHERE Jezyk=@choosenLang  AND Nauczone='TAK' ";
            }

            else
            {
                sql = "Select slowkoID from slowka WHERE Kategoria=@choosenCat AND Jezyk=@choosenLang  AND Nauczone='TAK' ";
            }
            conn.Open();
            //SQL command
            SqlCommand cmd = new SqlCommand(sql, conn);
            //Parameters
            cmd.Parameters.AddWithValue("@choosenLang", choosenLang);
            cmd.Parameters.AddWithValue("@choosenCat", choosenCat);


            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                nauczone++;
                label4.Text = nauczone.ToString();
            }

            conn.Close();

            //Load not learned
            conn.Open();

            if (choosenCat == "Wszystkie")
            {
                sql2 = "Select slowkoID from slowka WHERE Jezyk=@choosenLang  AND Nauczone='NIE' ";
            }

            else
            {
                sql2 = "Select slowkoID from slowka WHERE Kategoria=@choosenCat AND Jezyk=@choosenLang  AND Nauczone='NIE' ";
            }

            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            //Parameters
            cmd2.Parameters.AddWithValue("@choosenLang", choosenLang);
            cmd2.Parameters.AddWithValue("@choosenCat", choosenCat);

            SqlDataReader dr2 = cmd2.ExecuteReader();


            while (dr2.Read())
            {
                nienauczone++;
                label6.Text = nienauczone.ToString();
            }

            conn.Close();

            //Load all words

            conn.Open();

            if (choosenCat == "Wszystkie")
            {
                sql1 = "Select slowkoID from slowka WHERE Jezyk=@choosenLang ";
            }

            else
            {
                sql1 = "Select slowkoID from slowka WHERE Kategoria=@choosenCat AND Jezyk=@choosenLang  ";
            }

            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            //Parameters
            cmd1.Parameters.AddWithValue("@choosenLang", choosenLang);
            cmd1.Parameters.AddWithValue("@choosenCat", choosenCat);

            SqlDataReader dr1 = cmd1.ExecuteReader();


            while (dr1.Read())
            {
                wszystkie++;
                label2.Text = wszystkie.ToString();
            }

            conn.Close();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            choosenLang = "Angielski";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            choosenLang = "Niemiecki";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosenCat = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadStats();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
