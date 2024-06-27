using System;

namespace HazirDateTimeMathMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek); // Haftanın gününü string halde getirir.
            Console.WriteLine(DateTime.Now.DayOfYear); // Yılın kaçıncı günündeyim?

            Console.WriteLine(DateTime.Now.ToLongDateString()); // UI da kullanılabilir
            Console.WriteLine(DateTime.Now.ToShortDateString()); // Daha çok kullanılır.
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            // DateTimee Format

            Console.WriteLine(DateTime.Now.ToString("dd")); //günün int karşılığı
            Console.WriteLine(DateTime.Now.ToString("ddd")); //günün string karşılığı(kısa) - Sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); //günün string karşılığı(uzun) - Saturday

            Console.WriteLine(DateTime.Now.ToString("MM")); // ayın int karşılığı
            Console.WriteLine(DateTime.Now.ToString("MMM")); // ayın string karşılığı (kısa) - Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // ayın string karşılığı (uzun) - April

            Console.WriteLine(DateTime.Now.ToString("yy")); // yılın kısaltılmış hali - 24
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // yılın uzatılmış hali - 2024

            Console.WriteLine("***************** MATH KÜTÜPHANESİ *****************");
            
            Console.WriteLine(Math.Abs(-25)); // Mutlak değer alır. (25)
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));
            
            Console.WriteLine(Math.Ceiling(22.3)); // 22.3 den büyük en küçük tamsayı (23)
            Console.WriteLine(Math.Round(22.3)); // Hangisine daha yakınsa onu verir. 22ye daha yakın 22 çıktısını verir.
            Console.WriteLine(Math.Floor(22.7)); // 22.7 den küçük en büyük tamsayı (22)
            Console.WriteLine(Math.Max(2,6)); // 2 sayının max olanı getirir.
            Console.WriteLine(Math.Min(2,6)); // 2 sayının min olanı getirir.
            
            Console.WriteLine(Math.Pow(3,4)); // üst alma. 81 çıktısı verir
            Console.WriteLine(Math.Sqrt(9)); // Karekök alır. 3 verir
            Console.WriteLine(Math.Log(9)); // Log alır. 9 un e tabanındaki log karşılığı
            Console.WriteLine(Math.Log10(100)); // Log alır. 100 un 10 tabanındaki log karşılığı
            Console.WriteLine(Math.Exp(3)); // e üzeri 3 ü verir.



        }
    }
}
