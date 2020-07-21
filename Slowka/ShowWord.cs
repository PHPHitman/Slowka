using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Internal;
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
        private int los = -1;
        private int ID = 0;
        private bool flag = true;

        //Bieżące słówko
        
        private int bledne = 0;
        private int poprawne = 0;


        public ShowWord()
        {
            InitializeComponent();
        }
       


        
        private void button1_Click(object sender, EventArgs e)
        {
            GoodAnswear();
        }


        private string choosenLang = Category.language;
        private string choosenCat = Category.category;
        private void button4_Click(object sender, EventArgs e)
        {
            ShowTranslate();
        }


        public void LoadWord()
        {
            {
                label4.Text = "";
                label5.Text = "";
                SqlConnection conn = new SqlConnection(myconnstring);
                SqlConnection conn2 = new SqlConnection(myconnstring);
                SqlConnection conn3 = new SqlConnection(myconnstring);
                //Update database
                string sql, sql2;
                if (choosenCat == "Wszystkie")
                {
                    sql = "Select slowkoID from slowka WHERE Jezyk=@choosenLang  AND Nauczone='Nie' ";
                    sql2 = "Select count(slowkoID) from slowka WHERE Jezyk=@choosenLang  AND Nauczone='Nie' ";
                }
            
                else 
                {
                    sql = "Select slowkoID from slowka WHERE Kategoria=@choosenCat AND Jezyk=@choosenLang  AND Nauczone='Nie' ";
                    sql2 = "count(slowkoID) from slowka WHERE Kategoria=@choosenCat AND Jezyk=@choosenLang  AND Nauczone='Nie' ";
                }
                conn.Open();
                conn2.Open();
                conn3.Open();
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
                if(many == 0)
                {
                    MessageBox.Show("Wszystkie słówka w kategorii "+ choosenCat + "są nauczone ! :)" );
                    this.DialogResult = DialogResult.OK;
                }
                int[] Tab_ID = new int[many];

                if (many != 0)
                {
                    for (int i = 0; i < many; i++)
                    {

                        dr.Read();
                        Tab_ID[i] = dr.GetInt32(0);

                    }
                    int losowanie;
                    if (flag)
                    {
                        Random los2 = new Random();
                        losowanie = los2.Next() % many;
                        los = losowanie;
                    }
                    else
                    {


                        do
                        {
                            Random los2 = new Random();

                            losowanie = los2.Next() % many;
                        } while ((losowanie == los && many != 1) || many == 1);
                        los = losowanie;
                    }
                    flag = true;

                    SqlCommand cmd3 = new SqlCommand(
                        "Select Slowko, Poprawne, Bledne from slowka WHERE slowkoID=@los ", conn3);
                    ID = Tab_ID[los];
                    cmd3.Parameters.AddWithValue("@los", ID);
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    dr3.Read();

                    label4.Text = dr3.GetString(0);
                    poprawne = dr3.GetInt32(1);
                    bledne = dr3.GetInt32(2);
                }









                conn.Close();
                conn2.Close();
                conn3.Close();
            }
        }

        public void ShowTranslate()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            string sql;
            
            //Update database
            if (choosenCat == "Wszystkie")
            {
               
                sql = "Select Tlumaczenie from slowka WHERE Jezyk=@choosenLang AND Nauczone='Nie' AND slowkoID=" + ID;
            }
            else
            {
                sql = "Select Tlumaczenie from slowka WHERE Kategoria=@choosenCat AND Jezyk=@choosenLang AND Nauczone='Nie' AND slowkoID=" + ID;
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
    
        public void ChangeStatus()
        {
          
                SqlConnection conn = new SqlConnection(myconnstring);
               
                    //Update database
                    string sql = "UPDATE slowka SET Nauczone='Tak' WHERE SlowkoID=@slowkoID";

                    //SQL command
                    SqlCommand cmd = new SqlCommand(sql, conn);
            //Parameters
              
                    cmd.Parameters.AddWithValue("@slowkoID", ID);

                    //Open database connection
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

            MessageBox.Show("Dodano do nauczonych!" + ID);
            conn.Close();
            LoadWord();
            


            
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
                cmd.Parameters.AddWithValue("@slowkoID", ID);

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
            cmd.Parameters.AddWithValue("@slowkoID", ID);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Dodano błędną odpowiedź!");
            conn.Close();

            LoadWord();

        }



        private void ShowWord_Load(object sender, EventArgs e)
        {
            LoadWord();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            ChangeStatus();
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
