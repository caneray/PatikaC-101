using System;

namespace Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ***************** 1. BAŞLIK ******************
            /*
            Console.WriteLine("Kaç adet sayı gireceksiniz?");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Pozitif {0}. elemanı girin: ", i+1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var sayi in dizi)
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine(sayi);
                }
            }
            */
            // -------------------------------------------------------------

            // ***************** 2. BAŞLIK ******************

            /*
            Console.WriteLine("Pozitif 2 sayı giriniz!");
            Console.Write("1. Sayı :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayı :");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kaç tane karşılaştırılacak pozitif sayı gireceksiniz");
            int diziBoyutu = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[diziBoyutu];
            for (int i = 0; i < diziBoyutu; i++)
            {
                Console.Write(" {0}. sayi girin: ", i + 1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var sayi in dizi)
            {
                if (sayi == m || sayi % m == 0)
                {
                    Console.WriteLine(sayi);
                }
            }

            */
            // -------------------------------------------------------------


            // ***************** 3. BAŞLIK ******************
            /*
            Console.WriteLine("Kaç adet kelime gireceksiniz?");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kelimeleri giriniz.");
            string[] dizi = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. kelimeyi girin: ", i + 1);
                dizi[i] = Console.ReadLine();
            }

            foreach (var kelime in dizi)
            {
                Console.Write(kelime + " ");
            }
            */
            // -------------------------------------------------------------


            // ***************** 4. BAŞLIK ******************
            Console.WriteLine("Lütfen bir cümle yazın:");
            string cumle = Console.ReadLine();

            // Kelimeleri boşluklara göre bölme
            string[] kelimeler = cumle.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int kelimeSayisi = kelimeler.Length;

            // Harfleri sayma (yalnızca alfabe harfleri sayılır)
            int harfSayisi = 0;
            foreach (char c in cumle)
            {
                if (char.IsLetter(c))
                {
                    harfSayisi++;
                }
            }

            Console.WriteLine("Toplam kelime sayısı: " + kelimeSayisi);
            Console.WriteLine("Toplam harf sayısı: " + harfSayisi);

        }
    }
}
