using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Otomasyonu
{
     public class Masa
    {
        public int Id { get; set; } 
        public string MasaKodu { get; set;}
        public string MasaAdi { get; set; }
       public List<UrunHareket> Hareket { get; set; }
        public string Name { get; internal set; }
        public string Text { get; internal set; }
        public int Height { get; internal set; }
        public int Width { get; internal set; }
    }
}