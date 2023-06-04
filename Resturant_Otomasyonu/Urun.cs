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
        public string Name { get; internal set; }
        public string  Text { get; internal set; }
        public double Height { get; internal set; }
        public double Width { get; internal set; }

    }
}
