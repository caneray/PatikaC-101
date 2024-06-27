using System;
using System.Collections.Generic;

namespace Odev2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle giriniz:");
            string cumle = Console.ReadLine().ToLower(); // Cümleyi küçük harfe çeviriyoruz

            List<char> sesliHarfler = new List<char>();
            char[] sesli = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' }; // Türkçe sesli harfler

            foreach (char c in cumle)
            {
                if (Array.IndexOf(sesli, c) != -1 && !sesliHarfler.Contains(c)) // Sesli harfse ve daha önce eklenmemişse
                {
                    sesliHarfler.Add(c);
                }
            }

            sesliHarfler.Sort(); // Sesli harfleri sıralıyoruz

            Console.WriteLine("Girdiğiniz cümledeki sesli harfler:");
            foreach (char harf in sesliHarfler)
            {
                Console.WriteLine(harf);
            }
        }
    }
}
