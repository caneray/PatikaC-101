using System;

namespace ToDoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            bool uygulamaDevam = true;

            while (uygulamaDevam)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                Console.WriteLine("(0) Uygulamadan Çık");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        board.BoardListele();
                        break;
                    case "2":
                        Console.Write("Başlık Giriniz: ");
                        string baslik = Console.ReadLine();
                        Console.Write("İçerik Giriniz: ");
                        string icerik = Console.ReadLine();
                        Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5): ");
                        int buyuklukSecim;
                        while (!int.TryParse(Console.ReadLine(), out buyuklukSecim) || buyuklukSecim < 1 || buyuklukSecim > 5)
                        {
                            Console.WriteLine("Geçersiz seçim! Lütfen tekrar deneyin: ");
                        }
                        KartBuyuklugu buyukluk = (KartBuyuklugu)buyuklukSecim;

                        Console.Write("Kişi Seçiniz (ID ile): ");
                        int kisiId;
                        while (!int.TryParse(Console.ReadLine(), out kisiId))
                        {
                            Console.WriteLine("Geçersiz ID! Lütfen tekrar deneyin: ");
                        }

                        board.KartEkle(baslik, icerik, kisiId, buyukluk, "TODO");
                        break;
                    case "3":
                        Console.Write("Lütfen silmek istediğiniz kartın başlığını yazınız: ");
                        string silBaslik = Console.ReadLine();
                        board.KartSil(silBaslik);
                        break;
                    case "4":
                        Console.Write("Lütfen taşımak istediğiniz kartın başlığını yazınız: ");
                        string tasimaBaslik = Console.ReadLine();

                        while (true)
                        {
                            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                            Console.WriteLine("(1) TODO");
                            Console.WriteLine("(2) IN PROGRESS");
                            Console.WriteLine("(3) DONE");

                            string lineSecim = Console.ReadLine();
                            string yeniLine = "";
                            switch (lineSecim)
                            {
                                case "1":
                                    yeniLine = "TODO";
                                    break;
                                case "2":
                                    yeniLine = "IN PROGRESS";
                                    break;
                                case "3":
                                    yeniLine = "DONE";
                                    break;
                                default:
                                    Console.WriteLine("Hatalı bir seçim yaptınız! Lütfen tekrar deneyin.");
                                    continue; // Geçersiz seçim durumunda döngünün başına dön
                            }

                            if (!string.IsNullOrEmpty(yeniLine))
                            {
                                board.KartTasi(tasimaBaslik, yeniLine);
                                break; // Taşıma işlemi başarılı olduğunda döngüyü sonlandır
                            }
                        }
                        break;
                    case "0":
                        uygulamaDevam = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim! Lütfen tekrar deneyin.");
                        break;
                }
            }
        }
    }
}
