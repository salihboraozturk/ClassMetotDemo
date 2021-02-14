using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {   
        List<string> musteriler = new List<string>();
        public void musteriEkle(Musteri musteri)
        {
            
            Console.WriteLine("Müşteri eklendi:"+musteri.Id+musteri.musteriAdi+musteri.musteriSoyadi);
           
            

        }
        public void musteriSil(Musteri musteri)
        {
         Console.WriteLine("Müşteri silindi:" + musteri.Id + musteri.musteriAdi + musteri.musteriSoyadi);

        }
        public void musteriListele(List<Musteri>musteriler)
        {
            foreach (Musteri listele in musteriler)
            {
                Console.WriteLine(listele.musteriAdi); 
            }


        }
    }
}
