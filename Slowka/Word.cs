using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slowka
{
    public class Word
    {
        public int SlowkoID { get; set; }
        public string Slowko { get; set; }
        public string Tlumaczenie { get; set; }
        public string Kategoria { get; set; }

        public string Jezyk { get; set; }

        public string Nauczone { get; set; }

        public int Bledne { get; set; }

        public int Poprawne { get; set; }
    }
}
