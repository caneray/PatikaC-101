using System;

namespace KurucuMetotlar
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

            /* 
             Bir sınıftan bir nesne oluşturulduğunda biz tanımlamasak bile arka planda çalışan varsayılan yapıcı metotlara kurucu yada constructor denir. Sınıf nesnesi ilk oluşturulduğunda yapılmasını istediğimiz işleri kurucu metotlar içerisinde yaparız.
               Kurucu metot tanımlarken dikkat edilmesi gereken noktalar ise şu şekildedir:

                    1. Yapıcı metotların isimleri sınıf isimleri ile aynı olmak zorundadır.
                    2. Public olarak bildirilmeleri gerekir.
                    3. Geri dönüş değerleri yoktur.
             
             
             */


            Calisan calisan1 = new Calisan("Caner","Ay",23425634,"Yazılım"); // metot overload aşırı yükleme
            calisan1.CalisanBilgileri();

            Console.WriteLine("----------------------------------------------------");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Buse";
            calisan2.Soyad = "Ay";
            calisan2.No = 12345678;
            calisan2.Departman = "İnsan Kaynakları";
            calisan2.CalisanBilgileri();

            Console.WriteLine("----------------------------------------------------");

            Calisan calisan3 = new Calisan("Çağla","Şılak");
            calisan3.CalisanBilgileri();



        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman) //Class ismiyle aynı olmalı (ctor)(Constructer)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan() { } //parametre almadan da çalışması için

        public Calisan(string ad, string soyad)
        {
            this.Ad= ad;
            this.Soyad= soyad;
        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0} ", Ad);
            Console.WriteLine("Çalışan Soyadı:{0} ", Soyad);
            Console.WriteLine("Çalışan Numarası:{0} ", No);
            Console.WriteLine("Çalışanın Departmanı:{0} ", Departman);
        }
    }
}
