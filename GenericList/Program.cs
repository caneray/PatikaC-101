using System;
using System.Collections.Generic;

namespace GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // syntax yapısı List<T> class
            // System.Collections.Generic
            // T -> Object türündedir. Liste içerisindeki nesnenin tipini gösterir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            // Count
            Console.WriteLine(renkListesi.Count); //Liste içerisindeki eleman sayısı
            Console.WriteLine(sayiListesi.Count); //Liste içerisindeki eleman sayısı

            // Foreach ve List.Foreach ile Elemanları yazdırma
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Listeden Eleman Çıkartma
            sayiListesi.Remove(4); // 4 ü çıkar
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0); // 0. indexteki elemanı çıkar
            renkListesi.RemoveAt(1); // 1. indexteki elemanı çıkar

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Liste İçerisinde Arama
            if (sayiListesi.Contains(10))
                Console.WriteLine("10 Liste içerisinde bulundu!");

            // Elemanı vererek indexe erişim
            Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));

            // Diziyi List'e çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);

            // Listeyi Temizleme
            hayvanListesi.Clear();

            // List içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Caner";
            kullanici1.Soyisim = "Ay";
            kullanici1.Yas = 24;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Çağla";
            kullanici2.Soyisim = "Şılak";
            kullanici2.Yas = 23;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();

            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Buse",
                Soyisim = "Ay",
                Yas = 18
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanici.Soyisim);
                Console.WriteLine("Yaşı: " + kullanici.Yas);
            }
            yeniListe.Clear();


        }
    }

    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }

    }
}
