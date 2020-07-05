using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slowka.SlowkaKlasy
{
    class EnglishWords
    {
        //Getter Setter
        public int SlowkoID  { get; set; }
        public string Slowko { get; set; }
        public string Tlumaczenie { get; set; }
        public string Kategoria { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        
        public DataTable Select()
        {
            //1 Połączenie z bazą
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //SQL Query
                string sql = "SELECT * FROM Slowka";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool Insert (EnglishWords s)
        {
            bool isSuccess = false;

            //1Połączenie z bazą danych
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //2 SQL Query przesłanie danych
                string sql = "INSERT INTO Slowka (Slowko, Tlumaczenie, Kategoria) VALUES(@Slowko, @Tlumaczenie, @Kategoria)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                //Tworzenie parametrów do przesłania danych
                cmd.Parameters.AddWithValue("@Slowko", s.Slowko);
                cmd.Parameters.AddWithValue("@Tlumaczenie", s.Tlumaczenie);
                cmd.Parameters.AddWithValue("@Kategoria", s.Kategoria);

                //Connection Open
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
           
            return isSuccess;
        }


    }
}
