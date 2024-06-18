using System;

namespace If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time>=6 && time<11)
                Console.WriteLine("Günaydın!");
            else if (time <= 18)
                Console.WriteLine("İyi Günler!");
            else
                Console.WriteLine("İyi Geceler!");


            //string sonuc = time < 18 ? "İyi Günler" : "İyi Geceler";

            string sonuc = time >= 6 && time < 11 ? "Günaydın" : time < 18 ? "İyi Günler!" : "İyi Geceler!";
            Console.WriteLine(sonuc);


            int n = Convert.ToInt32(Console.ReadLine().Trim());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + "x" + i + "=" + n * i);
            }
        }
    }
}
