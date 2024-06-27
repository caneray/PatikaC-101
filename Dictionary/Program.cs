using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary -> key, value
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(10, "Caner AY");
            kullanicilar.Add(12, "Çağla Şılak");
            kullanicilar.Add(18, "Buse Ay");
            kullanicilar.Add(20, "Ali Ay");

            // Dizinin elemanlarına erişim
            Console.WriteLine("********** Elemanlara Erişim **********");
            Console.WriteLine(kullanicilar[12]);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            // Count
            Console.WriteLine("********** Count **********");
            Console.WriteLine("Kaç elemanlı : " + kullanicilar.Count);

            // Contains 
            Console.WriteLine("********** Contains **********");
            Console.WriteLine(kullanicilar.ContainsKey(12)); // 12 anahtarına sahip eleman var mı?
            Console.WriteLine(kullanicilar.ContainsValue("Zikriye Ürkmez"));

            // Remove
            Console.WriteLine("********** Remove **********");
            kullanicilar.Remove(20);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Value);
            }

            //Keys
            Console.WriteLine("********** Keys **********");
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }
            // Values
            Console.WriteLine("********** Values **********");
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
