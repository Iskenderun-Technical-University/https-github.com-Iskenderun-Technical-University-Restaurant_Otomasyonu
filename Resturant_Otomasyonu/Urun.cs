using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Otomasyonu
{
    public class Urun
    {
        public  int Id { get; set; }
        public String UrunKodu { get; set; }

        public String UrunAdi { get; set; }

        public String Birimi { get; set; }
        public double Fiyat { get; set; }

    }
}
