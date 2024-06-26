using System;

namespace HazirStringMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "Dersimiz CSharp";


            // Length
            Console.WriteLine(degisken.Length); // Karakter sayısına erişme

            // ToUpper, ToLower
            Console.WriteLine(degisken.ToUpper()); // Hepsini büyük harf yapar
            Console.WriteLine(degisken.ToLower()); // Hepsini küçük harf yapar

            // Concat
            Console.WriteLine(String.Concat(degisken,"Merhaba")); // Merhaba ile değişkeni birleştirir.

            // Compare, CompareTo

                // 1. değişken 2. değişkene eşit olursa 0 döndürür.
                // 1. değişken 2. değişkenden daha büyük bir karakter sayısına sahipse 1 döndürür.
                // 1. değişken 2. değişkenden daha küçük karakter sayısına sahipse -1 döndürür. 
            Console.WriteLine(degisken.CompareTo(degisken2));

                // IgnoreCase => iki değişkeni karşılaştırırken true dersek büyük küçük harf duyarsız hale gelir, false büyük küçük harf duyarlıdır.
            Console.WriteLine(String.Compare(degisken,degisken2,true));

            // Contains
            Console.WriteLine(degisken.Contains(degisken2)); //degiskenin içinde degisken2 var mı? Bulursa true döner
            
            // StartsWith, EndsWith
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!")); // Hoşgeldiniz ile bitiyor mu?
            Console.WriteLine(degisken.StartsWith("Hoşgeldiniz!")); // Hoşgediniz ile başlıyor mu?

            // IndexOf, LastIndexOf
            Console.WriteLine(degisken.IndexOf("CS")); // Değişken içerisinde arayıp bulduğunda C nin bulunduğu yani ilk harfin bulunduğu indexi verir.
            Console.WriteLine(degisken.IndexOf("Caner")); // Hiçbirşey bulamadığında -1 döner.
            Console.WriteLine(degisken.LastIndexOf("i")); // i bulunan son indexi getirir.

            // Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba! ")); // 0. indexten başlayarak stringin başına Merhaba yazar.

            // PadLeft, PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30)); // degisken2 nin soluna 30a tamamlayarak kadar boşluk ekler.
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*')); // degisken2 nin soluna 30a tamamlayarak kadar * ekler.
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2); // degisken2 nin soluna 30a tamamlayarak kadar * ekler.

            // Remove
            Console.WriteLine(degisken.Remove(10)); //10. indexten başlayarak sonuna kadar siler.
            Console.WriteLine(degisken.Remove(5,3)); //5. indexten başlayarak 3 karakter sil.
            Console.WriteLine(degisken.Remove(0,1)); //0. indexten başlayarak 1 karakter sil. En baştaki karakteri sil.

            // Replace
            Console.WriteLine(degisken.Replace("CSharp","C#")); // CSharp yerine c# yazar.

            // Split
            Console.WriteLine(degisken.Split(' ')[1]); // boşluklara göre parçala ve 1. indexteki veriyi getir.

            // SubString
            Console.WriteLine(degisken.Substring(4,6)); //4. indexten başlayarak 6 karakter getirir.
            Console.WriteLine(degisken.Substring(4)); //4. indexten başlayarak sonuna kadar getirir.


        }
    }
}
