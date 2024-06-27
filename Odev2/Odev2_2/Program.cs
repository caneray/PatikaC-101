using System;
using System.Collections;

namespace Odev2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 adet pozitif sayı giriniz");
            ArrayList sayilar = new ArrayList();
            ArrayList enBuyukler = new ArrayList();
            ArrayList enKucukler = new ArrayList();

            try
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write("{0}. sayıyı giriniz : ", i + 1);
                    int n = Convert.ToInt32(Console.ReadLine());
                    sayilar.Add(n);
                }

                sayilar.Sort();

                // En büyük 3 sayıyı enBuyukler listesine ekle
                for (int i = 0; i < 3; i++)
                {
                    enBuyukler.Add(sayilar[sayilar.Count - 1 - i]);
                }

                // En küçük 3 sayıyı enKucukler listesine ekle
                for (int i = 0; i < 3; i++)
                {
                    enKucukler.Add(sayilar[i]);
                }
                int enBuyukToplam = 0;
                int enKucukToplam = 0;
                Console.WriteLine("En büyük 3 sayı:");
                foreach (var item in enBuyukler)
                {
                    Console.WriteLine(item);
                    enBuyukToplam += Convert.ToInt32(item);
                }

                Console.WriteLine("En küçük 3 sayı:");
                foreach (var item in enKucukler)
                {
                    Console.WriteLine(item);
                    enKucukToplam += Convert.ToInt32(item);
                }
                Console.WriteLine("En Büyüklerin Toplamı : " + enBuyukToplam);
                Console.WriteLine("En Küçüklerin Toplamı : " + enKucukToplam);
                Console.WriteLine("En Büyüklerin Ortalaması : " + enBuyukToplam/enBuyukler.Count);
                Console.WriteLine("En Küçüklerin Ortalaması : " + enKucukToplam/enKucukler.Count);


            }
            catch (Exception ex)
            {
                Console.WriteLine("Lütfen sayı giriniz! Hata Kodu :" + ex.Message);
            }
        }
    }
}
