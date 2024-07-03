using System;

namespace StaticSinifveUyeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı = {0}",Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Caner","Ay","Yazılım");
            Console.WriteLine("Çalışan Sayısı = {0}", Calisan.CalisanSayisi);

            Calisan calisan1 = new Calisan("Deniz", "Arda", "Yazılım");
            Calisan calisan2 = new Calisan("Çağla", "Şılak", "Yazılım");
            Console.WriteLine("Çalışan Sayısı = {0}", Calisan.CalisanSayisi);


            //Islemler islemler = new Islemler(); // Erişilmez

            //Islemler.Topla(100, 200); //statik sınıflara SinifAdi. şeklinde erişilir.
            Console.WriteLine("Toplama İşlemi Sonucu = {0}", Islemler.Topla(100, 200));
            Console.WriteLine("Çıkarma İşlemi Sonucu = {0}", Islemler.Cikar(400, 200));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }
        public Calisan(string ısim, string soyisim, string departman)
        {
            this.Isim = ısim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler //Statik sınıfların içerisine static harici herhangi bir sınıf tanımlayamayız.
    {
        public static long Topla(int sayi1, int sayi2) 
        {
            return sayi1 + sayi2;
        }
        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
