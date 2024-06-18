using System;

namespace HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try //Hataya neden olabilecek kodu try içine yazılır.
            {
                Console.WriteLine("Bir Sayı Giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen Sayi : " + sayi);
            }

            catch (Exception ex) //hatayı yakalamak için ve ekrana yazdırmak için
            { 
                Console.WriteLine("Hata : " + ex.Message.ToString());
            }
            finally //try içerisindeki kod hatalı olsun olmasın bir şart olmaksızın bu alandaki kod yazılır. Finally bloğu zorunlu değil.
            {
                Console.WriteLine("İşlem Tamamlandı.");
            }


            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Boş değer girdiniz!");
                Console.WriteLine(ex); //Hatanın tamamını yazdırır.
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri Tipi Uygun değil!");
                Console.WriteLine(ex); //Hatanın tamamını yazdırır.
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz!");
                Console.WriteLine(ex); //Hatanın tamamını yazdırır.
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }


        }
    }
}
