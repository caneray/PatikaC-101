using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class Board
    {
        private List<Kart> Todo;
        private List<Kart> InProgress;
        private List<Kart> Done;
        private List<TakimUyesi> TakimUyeleri;

        public Board()
        {
            Todo = new List<Kart>();
            InProgress = new List<Kart>();
            Done = new List<Kart>();

            TakimUyeleri = new List<TakimUyesi>
        {
            new TakimUyesi(1, "Ali"),
            new TakimUyesi(2, "Veli"),
            new TakimUyesi(3, "Ayşe")
        };

            Todo.Add(new Kart("Görev 1", "İçerik 1", TakimUyeleri[0], KartBuyuklugu.M, "TODO"));
            InProgress.Add(new Kart("Görev 2", "İçerik 2", TakimUyeleri[1], KartBuyuklugu.S, "IN PROGRESS"));
            Done.Add(new Kart("Görev 3", "İçerik 3", TakimUyeleri[2], KartBuyuklugu.XL, "DONE"));
        }

        public void KartEkle(string baslik, string icerik, int kisiId, KartBuyuklugu buyukluk, string line)
        {
            var kisi = TakimUyeleri.FirstOrDefault(k => k.Id == kisiId);
            if (kisi == null)
            {
                Console.WriteLine("Hatalı girişler yaptınız!");
                return;
            }

            var kart = new Kart(baslik, icerik, kisi, buyukluk, line);

            if (line == "TODO") Todo.Add(kart);
            else if (line == "IN PROGRESS") InProgress.Add(kart);
            else if (line == "DONE") Done.Add(kart);
        }

        public void KartGuncelle(string baslik, string yeniBaslik, string yeniIcerik, int yeniKisiId, KartBuyuklugu yeniBuyukluk)
        {
            var kart = Todo.Concat(InProgress).Concat(Done).FirstOrDefault(k => k.Baslik == baslik);
            if (kart == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı.");
                return;
            }

            var yeniKisi = TakimUyeleri.FirstOrDefault(k => k.Id == yeniKisiId);
            if (yeniKisi == null)
            {
                Console.WriteLine("Hatalı girişler yaptınız!");
                return;
            }

            kart.Baslik = yeniBaslik;
            kart.Icerik = yeniIcerik;
            kart.AtananKisi = yeniKisi;
            kart.Buyukluk = yeniBuyukluk;
        }

        public void KartSil(string baslik)
        {
            while (true)
            {
                var kart = Todo.FirstOrDefault(k => k.Baslik == baslik) ??
                           InProgress.FirstOrDefault(k => k.Baslik == baslik) ??
                           Done.FirstOrDefault(k => k.Baslik == baslik);

                if (kart == null)
                {
                    Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    string secim = Console.ReadLine();

                    if (secim == "1")
                        return; // Silme işlemini sonlandır
                    else if (secim == "2")
                    {
                        Console.Write("Lütfen silmek istediğiniz kartın başlığını tekrar yazınız: ");
                        baslik = Console.ReadLine();
                        continue; // Yeniden denemek için döngünün başına dön
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim! Lütfen tekrar deneyin.");
                        continue; // Geçersiz seçim durumunda da döngünün başına dön
                    }
                }

                if (kart.Line == "TODO") Todo.Remove(kart);
                else if (kart.Line == "IN PROGRESS") InProgress.Remove(kart);
                else if (kart.Line == "DONE") Done.Remove(kart);

                Console.WriteLine($"{kart.Baslik} başlıklı kart board'dan silindi.");
                break; // Silme işlemi başarılı olduğunda döngüyü sonlandır
            }
        }


        public void KartTasi(string baslik, string yeniLine)
        {
            while (true)
            {
                var kart = Todo.FirstOrDefault(k => k.Baslik == baslik) ??
                           InProgress.FirstOrDefault(k => k.Baslik == baslik) ??
                           Done.FirstOrDefault(k => k.Baslik == baslik);

                if (kart == null)
                {
                    Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    string secim = Console.ReadLine();

                    if (secim == "1")
                        return; // Taşıma işlemini sonlandır
                    else if (secim == "2")
                    {
                        Console.Write("Lütfen taşımak istediğiniz kartın başlığını tekrar yazınız: ");
                        baslik = Console.ReadLine();
                        continue; // Yeniden denemek için döngünün başına dön
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim! Lütfen tekrar deneyin.");
                        continue; // Geçersiz seçim durumunda da döngünün başına dön
                    }
                }

                // Kart bulundu, şimdi kartı yeniLine'a taşı
                if (kart.Line == "TODO") Todo.Remove(kart);
                else if (kart.Line == "IN PROGRESS") InProgress.Remove(kart);
                else if (kart.Line == "DONE") Done.Remove(kart);

                kart.Line = yeniLine;

                if (yeniLine == "TODO") Todo.Add(kart);
                else if (yeniLine == "IN PROGRESS") InProgress.Add(kart);
                else if (yeniLine == "DONE") Done.Add(kart);

                Console.WriteLine($"{kart.Baslik} başlıklı kart {yeniLine} line'ına taşındı.");
                break; // Taşıma işlemi başarılı olduğunda döngüyü sonlandır
            }
        }


        public void BoardListele()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            Listele(Todo);
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            Listele(InProgress);
            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");
            Listele(Done);
        }

        private void Listele(List<Kart> kartlar)
        {
            if (kartlar.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
                return;
            }

            foreach (var kart in kartlar)
            {
                Console.WriteLine($"Başlık      : {kart.Baslik}");
                Console.WriteLine($"İçerik      : {kart.Icerik}");
                Console.WriteLine($"Atanan Kişi : {kart.AtananKisi.Isim}");
                Console.WriteLine($"Büyüklük    : {kart.Buyukluk}");
                Console.WriteLine("-");
            }
        }
    }
}
