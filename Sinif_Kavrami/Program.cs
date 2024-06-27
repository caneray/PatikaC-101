using System;

namespace Sinif_Kavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Söz Dizimi
                class SinifAdi
                {
                    [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
                    [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listei])
                    {
                        // Metot Komutları
                    }
            */

            // Erişim Belirleyiciler
            // * Public => Her yerden erişilebilir.
            // * Private => Sadece tanımlandığı sınıf içerisinde erişilebilen metotlar private olarak tanımlanır.
            // * Internal => kendi bulunduğu proje içerisinde erişilebilen değişkenlere(property) ve methodlara denir
            // * Protected => sadece tanımlandığı sınıfta veya o sınıftan kalıtım alan diğer sınıflarda kullanılabilir.
            
            Calisan calisan1 = new Calisan(); // instance
            calisan1.Ad = "Caner";
            calisan1.Soyad = "Ay";
            calisan1.No = 23425634;
            calisan1.Departman = "Yazılım";

            calisan1.CalisanBilgileri();
            Console.WriteLine("----------------------------------------------------");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Buse";
            calisan2.Soyad = "Ay";
            calisan2.No = 12345678;
            calisan2.Departman = "İnsan Kaynakları";

            calisan2.CalisanBilgileri();
            
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0} ", Ad);
            Console.WriteLine("Çalışan Soyadı:{0} ", Soyad);
            Console.WriteLine("Çalışan Numarası:{0} ", No);
            Console.WriteLine("Çalışanın Departmanı:{0} ", Departman);
        }
    }
}
