using System;
using System.Collections;
using System.ComponentModel;

namespace Odev2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("20 adet pozitif sayı giriniz");
            //ArrayList sayilar = new ArrayList();
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write("{0}. sayıyı giriniz : ", i + 1);
                    int n = Convert.ToInt32(Console.ReadLine());
                    int kontrol = 0;
                    if (n > 0)
                    {
                        int j;
                        for (j = 2; j < n; j++)
                        {
                            if (n % j == 0)
                                kontrol++;
                        }

                        if (kontrol != 0)
                            asalOlmayanSayilar.Add(n);
                        else
                            if (n > 1)
                            asalSayilar.Add(n);
                    }
                }

                asalSayilar.Sort();
                asalSayilar.Reverse();

                asalOlmayanSayilar.Sort();
                asalOlmayanSayilar.Reverse();

                Console.WriteLine("***** Asal Sayılar *****");
                foreach (var item in asalSayilar)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("***** Asal Olmayan Sayılar *****");

                foreach (var item in asalOlmayanSayilar)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Asal Sayılar Eleman Sayısı :" + asalSayilar.Count);
                Console.WriteLine("Asal Olmayan Sayılar Eleman Sayısı :" + asalOlmayanSayilar.Count);
                int asalToplam = 0;
                foreach (var item in asalSayilar)
                {
                    asalToplam += Convert.ToInt32(item);
                }
                Console.WriteLine("Asal Sayılar Ortalaması :" + asalToplam / asalSayilar.Count);

                int asalOlmayanToplam = 0;
                foreach (var item in asalOlmayanSayilar)
                {
                    asalOlmayanToplam += Convert.ToInt32(item);
                }
                Console.WriteLine("Asal Sayılar Ortalaması :" + asalOlmayanToplam / asalOlmayanSayilar.Count);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Lütfen sayı giriniz!");
            }

        }
    }
}
