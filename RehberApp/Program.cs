using System;

namespace RehberApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rehber rehber = new Rehber();
            bool uygulamaDevam = true;

            while (uygulamaDevam)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                Console.WriteLine("(0) Uygulamadan Çık");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.Write("Lütfen isim giriniz: ");
                        string isim = Console.ReadLine();
                        Console.Write("Lütfen soyisim giriniz: ");
                        string soyisim = Console.ReadLine();
                        Console.Write("Lütfen telefon numarası giriniz: ");
                        string telefonNumarasi = Console.ReadLine();
                        rehber.NumaraKaydet(isim, soyisim, telefonNumarasi);
                        break;
                    case "2":
                        Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                        string silinecekIsimSoyisim = Console.ReadLine();
                        rehber.NumaraSil(silinecekIsimSoyisim, silinecekIsimSoyisim);
                        break;
                    case "3":
                        Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
                        string guncellenecekIsimSoyisim = Console.ReadLine();
                        Console.Write("Lütfen yeni telefon numarasını giriniz: ");
                        string yeniTelefonNumarasi = Console.ReadLine();
                        rehber.NumaraGuncelle(guncellenecekIsimSoyisim, guncellenecekIsimSoyisim, yeniTelefonNumarasi);
                        break;
                    case "4":
                        Console.WriteLine("Rehberi nasıl listelemek istersiniz?");
                        Console.WriteLine("(1) A-Z");
                        Console.WriteLine("(2) Z-A");
                        string listeSecim = Console.ReadLine();
                        rehber.RehberiListele(listeSecim == "1");
                        break;
                    case "5":
                        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                        Console.WriteLine("(1) İsim veya soyisime göre arama yapmak");
                        Console.WriteLine("(2) Telefon numarasına göre arama yapmak");
                        string aramaSecim = Console.ReadLine();
                        Console.Write("Lütfen arama kriterinizi giriniz: ");
                        string aramaKriteri = Console.ReadLine();
                        rehber.RehberdeAra(aramaKriteri, aramaSecim == "1");
                        break;
                    case "0":
                        uygulamaDevam = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        break;
                }
            }
        }
    }
}
