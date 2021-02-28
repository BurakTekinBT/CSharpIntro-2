using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri = new Musteri();

            musteri.Id = 13;
            musteri.Name = "Burak";
            musteri.SurName = "Tekin";
            musteri.Age = 27;

            Musteri musteri2 = new Musteri();

            musteri2.Id = 14;
            musteri2.Name = "Beyza";
            musteri2.SurName = "Tekin";
            musteri2.Age = 20;

            Musteri musteri3 = new Musteri();

            musteri3.Id = 15;
            musteri3.Name = "İlyas";
            musteri3.SurName = "Tekin";
            musteri3.Age = 46;


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri);


            Musteri[] musteriler = new Musteri[] { musteri, musteri2, musteri3};
            musteriManager.MusteriListele(musteriler);

            musteriManager.MusteriSil(musteri2);

            Console.ReadLine();
        }
    }
}
