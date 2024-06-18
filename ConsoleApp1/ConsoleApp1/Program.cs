using System;
using System.Security;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte b = 5;         // 1 byte
            sbyte a = 5;        // 1 byte
            short s = 5;        // 2 byte  
            ushort us = 5;      // 2 byte (0, 65365)

            Int16 i16 = 2;          // 2 byte
            int i = 2;              // 4 byte
            Int32 i32 = 2;          // 4 byte
            Int64 i64 = 2;          // 8 byte

            uint ui = 2;            // 4 byte
            long l = 2;             // 8 byte
            ulong ul = 2;           // 8 byte

            // Reel sayılar
            float f = 2;            // 4 byte
            double d = 2;           // 8 byte
            decimal c = 2;          // 16 byte

            char ch = '2';          // 2 byte
            string str = "Caner";   // sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt1 = DateTime.Now;
            Console.WriteLine(dt1);

            object o1 = "x"; //string
            object o2 = 'c'; //char
            object o3 = 3;
            object o4 = 4.3;

            // String ifadeler;

            string str1 = string.Empty; //boş bir string
            str1 = "Caner Ay";

            string ad = "Caner ";
            string soyad = "Ay";

            string tamIsim = ad + " " + soyad;

            // Integer ifadeler;

            int int1 = 16;
            int int2 = 25;

            int carpim = int1 * int2;

            // Boolean

            bool bool1 = 10 < 2; //false
            bool bool2 = 10 > 2; //true


            // Değişken Dönüşümleri;

            string str20 = "20";
            int int20 = 24;

            string yeniDeger = str20 + int20.ToString();

            Console.WriteLine(yeniDeger); // Çıktısı 2024


            // Integer Dönüşümler;

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // Çıktısı 44

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22); // Çıktısı 44


            // DateTime

            string datetime = DateTime.Now.ToString("dd.mm.yyyy");
            Console.WriteLine(datetime);

        }
    }
}
