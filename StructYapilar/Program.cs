using System;

namespace StructYapilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;
            Console.WriteLine("Class Alan Hesabı : {0}", dikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_Struct;
            //Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct();
            dikdortgen_Struct.KisaKenar = 3;
            dikdortgen_Struct.UzunKenar = 4;
            Console.WriteLine("Struct Alan Hesabı : {0}", dikdortgen_Struct.AlanHesapla());

            Dikdortgen_Struct dikdortgen_Struct1 = new Dikdortgen_Struct(3,4);
            Console.WriteLine("Struct Alan Hesabı : {0}", dikdortgen_Struct1.AlanHesapla());


        }
    }

    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public Dikdortgen()
        {
            KisaKenar = 3;
            UzunKenar = 4;
        }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        /* Parametresi olmayan constructor structlarda tanımlanamaz!
        public Dikdortgen_Struct()
        {
            KisaKenar = 3;
            UzunKenar = 4;
        }  */

        public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
        {
            this.KisaKenar = kisaKenar;
            this.UzunKenar = uzunKenar;
        }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }

    }
}

/* NOT
 16 bayta kadar verileri saklamak için struct
 16 bayttan yüksek olan verileri class ile tutulmaswı daha sağlıklıdır.
*/