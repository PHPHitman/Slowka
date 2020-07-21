using System.Configuration;

namespace Words.WordClass
{
    public class Words
    {
        //Getter Setter
        public int SlowkoID  { get; set; }
        public string Slowko { get; set; }
        public string Tlumaczenie { get; set; }
        public string Kategoria { get; set; }

        public string Jezyk { get; set; }

        public string Nauczone { get; set; }

        public int Bledne { get; set; }

        public int Poprawne { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        
      
    }


    }


    
