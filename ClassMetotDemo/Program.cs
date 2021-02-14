using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri() {
              Id = 1,
            musteriAdi = "Ali",
            musteriSoyadi = "Fatinoğlu"
            };



        Musteri musteri2 = new Musteri() {
            Id = 2,
            musteriAdi = "Alihsan",
            musteriSoyadi = "Fatin",
        };
           

           
           MusteriManager musteriManager = new MusteriManager();
           musteriManager.musteriEkle(musteri1);
            musteriManager.musteriEkle(musteri2);

            List <Musteri> musteriler = new List<Musteri>() {musteri1,musteri2};
            musteriManager.musteriListele(musteriler);
            musteriManager.musteriSil(musteri1);
            musteriManager.musteriListele(musteriler);
        }
    }
}
