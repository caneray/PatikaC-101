using System;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
                Enum sıralama anlmaına gelir.
                Ardışık indexlerde kullanılır.
                Birden fazla sabite aynı anda ihtiyaç varsa(sabit = değeri belli olan değişkenler) kodun okunabilirliği arttırmak için kullanırız.
                Programın farklı farklı noktalarında değişken tanımlamak yerine enum kullanılırz.
             */

            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 32;
            if (sicaklik <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havann biraz daha ısınmasını bekleyelim.");
            }
            else if (sicaklik >= (int)HavaDurumu.Sicak)
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün.");
            else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSicak)
                Console.WriteLine("Hadi dışarıya çıkalım");
        }
    }

    enum Gunler
    {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30
    }
}
