﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Otomasyonu
{
    public partial class pageUrunler : Form
    {
 
        private List<Masa> Masalar = new List<Masa>();
        private List<Urun> Urunler = new List<Urun>();
        private List<UrunHareket> UrunHareketleri = new List<UrunHareket>();
        private Control masaButton;

        public pageUrunler()
        {
            InitializeComponent();
            Urunler.Add(new Urun
            {
                Id = 1,
                UrunKodu="1",
                UrunAdi="Çorba",
                Birimi="porsiyon",
                Fiyat=4.99
            });
     
            Urunler.Add(new Urun
            {
                Id = 2,
                UrunKodu = "2",
                UrunAdi = "İskender",
                Birimi = "porsiyon",
                Fiyat = 15.00
            });
            Urunler.Add(new Urun
            {
                Id = 3,
                UrunKodu = "3",
                UrunAdi = "Adana Kebap",
                Birimi = "dürüm",
                Fiyat = 22.50
            });
            Urunler.Add(new Urun
            {
                Id = 4,
                UrunKodu = "4",
                UrunAdi = "Yuvalama",
                Birimi = "porsiyon",
                Fiyat = 25.50
            });
            Urunler.Add(new Urun
            {
                Id = 5,
                UrunKodu = "5",
                UrunAdi = "Balık",
                Birimi = "porsiyon",
                Fiyat = 15.55
            });
            Urunler.Add(new Urun
            {
                Id = 6,
                UrunKodu = "6",
                UrunAdi = "Baklava",
                Birimi = "kilo",
                Fiyat = 45.99
            });

            Masalar.Add(new Masa
            {
                Id=1,
                MasaKodu="1",
                MasaAdi="Masa-1"
            });

            Masalar.Add(new Masa
            {
                Id = 2,
                MasaKodu = "2",
                MasaAdi = "Masa-2"
            });
            Masalar.Add(new Masa
            {
                Id = 3,
                MasaKodu = "3",
                MasaAdi = "Masa-3"
            });
            Masalar.Add(new Masa
            {
                Id = 4,
                MasaKodu = "4",
                MasaAdi = "Masa-4"
            });
            Masalar.Add(new Masa
            {
                Id = 5,
                MasaKodu = "5",
                MasaAdi = "Masa-5"
            });
            Masalar.Add(new Masa
            {
                Id = 6,
                MasaKodu = "6",
                MasaAdi = "Masa-6"
            });
            ButonOluştur();
        }
   

        private  void ButonOluştur()
        {
          

            foreach ( var masa in Masalar)
            {

                Masalar.Add(new Masa{
               
                Name =masa.MasaKodu,
                Text =masa.MasaKodu,
                Height=80,
                Width=80

                });
                flowmasalar.Controls.Add(masaButton);
                masaButton.Click += Masa_Click;
            }
        }

        private void Masa_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}