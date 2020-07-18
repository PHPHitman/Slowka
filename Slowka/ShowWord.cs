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

namespace Slowka
{
    public partial class ShowWord : Form
    {

        EnglishWords ew = new EnglishWords();
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //Array with all ID's
        int los = 0;


        //Bieżące słówko
        private int wordID = 0;
        private int bledne = 0;
        private int poprawne = 0;


        public ShowWord()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoodAnswear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private string choosenLang = Category.language;
        private string choosenCat = Category.category;
        private void button4_Click(object sender, EventArgs e)
        {
            ShowTranslate();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void LoadWord()
        {
            {
                label4.Text = "";
                label5.Text = "";
                SqlConnection conn = new SqlConnection(myconnstring);
                SqlConnection conn2 = new SqlConnection(myconnstring);
                //Update database
                string sql, sql2;
                if (choosenCat == "Wszystkie")
                {
                    sql = "Select slowkoID, Slowko, Poprawne, Bledne from slowka WHERE Jezyk=@choosenLang  AND Nauczone='Nie' ";
                    sql2 = "Select count(slowkoID) from slowka WHERE Jezyk=@choosenLang  AND Nauczone='Nie' ";
                }
            
                else 
                {
                    sql = "Select slowkoID, Slowko, Poprawne, Bledne from slowka WHERE Kategoria=@choosenCat AND Jezyk=@choosenLang  AND Nauczone='Nie' ";
                    sql2 = "count(slowkoID) from slowka WHERE Kategoria=@choosenCat AND Jezyk=@choosenLang  AND Nauczone='Nie' ";
                }
                conn.Open();
                conn2.Open();
                //SQL command
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlCommand cmd2 = new SqlCommand(sql2, conn2);
                //Parameters
                cmd.Parameters.AddWithValue("@choosenLang", choosenLang);
                cmd.Parameters.AddWithValue("@choosenCat", choosenCat);
                cmd2.Parameters.AddWithValue("@choosenLang", choosenLang);
                cmd2.Parameters.AddWithValue("@choosenCat", choosenCat);


                SqlDataReader dr = cmd.ExecuteReader();
                SqlDataReader dr2 = cmd2.ExecuteReader();

                dr2.Read();
                int many = dr2.GetInt32(0);
                int[] Tab_ID = new int[many];
                string[] Tab_slowko = new string[many];
                int[] Tab_poprawne = new int[many];
                int[] Tab_bledne = new int[many];


                for (int i = 0; i < many; i++)
                {

                    dr.Read();
                    Tab_ID[i] = dr.GetInt32(0);
                    Tab_slowko[i] = dr.GetString(1);
                    Tab_poprawne[i] = dr.GetInt32(2);
                    Tab_bledne[i] = dr.GetInt32(3);








                }

                Random los2 = new Random();

                los = los2.Next() % many;
                label4.Text = Tab_slowko[los];
                poprawne = Tab_poprawne[los];
                bledne = Tab_bledne[los];










                conn.Close();
                conn2.Close();
            }
        }

        public void ShowTranslate()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            string sql;
            //Update database
            if (choosenCat == "Wszystkie")
            {
                sql = "Select Tlumaczenie from slowka WHERE Jezyk=@choosenLang AND Nauczone='Nie' AND slowkoID=" + (los + 1);
            }
            else
            {
                sql = "Select Tlumaczenie from slowka WHERE Kategoria=@choosenCat AND Jezyk=@choosenLang AND Nauczone='Nie' AND slowkoID=" + (los + 1);
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

                label5.Text = dr.GetValue(0).ToString();

            }
            conn.Close();
        }
    
        public void ChangeStatus(int id)
        {
          
                SqlConnection conn = new SqlConnection(myconnstring);
               
                    //Update database
                    string sql = "UPDATE Slowka SET Nauczone='Tak' WHERE SlowkoID=@slowkoID";

                    //SQL command
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //Parameters

                    cmd.Parameters.AddWithValue("@slowkoID", id);

                    //Open database connection
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

            MessageBox.Show("Dodano do nauczonych!");
            LoadWord();
            conn.Close();


            
        }
        public void GoodAnswear()
        {

            poprawne++;
            SqlConnection conn = new SqlConnection(myconnstring);

            conn.Open();
                string sql = "UPDATE slowka SET Poprawne=@poprawne WHERE SlowkoID=@slowkoID";

                //SQL command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Parameters
                cmd.Parameters.AddWithValue("@poprawne", poprawne);
                cmd.Parameters.AddWithValue("@slowkoID", wordID);

               cmd.ExecuteNonQuery();
               
               MessageBox.Show("Dodano poprawna!");
            conn.Close();

            LoadWord();
              
        }

        public void BadAnswear()
        {

            bledne++;
            SqlConnection conn = new SqlConnection(myconnstring);

            conn.Open();
            string sql = "UPDATE slowka SET Bledne=@bledne WHERE SlowkoID=@slowkoID";

            //SQL command
            SqlCommand cmd = new SqlCommand(sql, conn);

            //Parameters
            cmd.Parameters.AddWithValue("@bledne", bledne);
            cmd.Parameters.AddWithValue("@slowkoID", wordID);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Dodano błędną odpowiedź!");
            conn.Close();

            LoadWord();

        }



        private void ShowWord_Load(object sender, EventArgs e)
        {
            LoadWord();
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeStatus(wordID);
            LoadWord();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BadAnswear();
        }
    }
}
