using System;

namespace TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz Dönüşüm) => Düşük kapasiteliden yüksek kapasiteli

            Console.WriteLine("******* Implicit Conversion *******");
            Console.WriteLine(" ");
            byte a = 5;
            sbyte b = 30;
            short c = 25;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Caner";
            char f = 'a';
            char ay = 'y';
            object g = e + f + ay + d;
            Console.WriteLine("g: " + g);



            // Explicit Conversion (Bilinçli Dönüşüm) => C# ın kendi kendine yapamadığı dönüşümler. Convert, Parse ve ToString kullanarak dönüşümler yapılır.
            Console.WriteLine(" ");
            Console.WriteLine("******* Explicit Conversion *******");
            Console.WriteLine(" ");


            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);
            
            float w = 10.3f; //veri kaybı , çevrimlerde veri kaybı olabilir göz önüne alınabilir.
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            // ToString Methodu
            Console.WriteLine(" ");
            Console.WriteLine("******* ToString Methodu *******");
            Console.WriteLine(" ");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " + zz);

            // Convert Methodu
            Console.WriteLine(" ");
            Console.WriteLine("******* Convert Methodu *******");
            Console.WriteLine(" ");

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + Toplam);

            
            // Parse Methodu
            Console.WriteLine(" ");
            Console.WriteLine("******* Parse Methodu *******");
            Console.WriteLine(" ");

            ParseMethod();


        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10,25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("Rakam1 : " + rakam1);
            Console.WriteLine("Double1 : " + double1);
            


        }
    }

    
}
