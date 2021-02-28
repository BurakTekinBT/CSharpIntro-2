using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi. Eklenen Müşteri : " + musteri.Id + musteri.Name + musteri.SurName +musteri.Age);
        }

        public void MusteriListele(Musteri[] musteriler)
        {

            foreach(Musteri mus in musteriler)
            {
                Console.WriteLine("Müşteri Listesi : " + mus.Id + mus.Name + mus.SurName + mus.Age);
            }
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Siliniyor. Silinen Müşteri: " + musteri.Id + musteri.Name + musteri.SurName + musteri.Age);
        }


    }
}
