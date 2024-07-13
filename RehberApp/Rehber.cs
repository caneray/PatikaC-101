using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehberApp
{
    public class Rehber
    {
        private List<Kisi> kisiler;

        public Rehber()
        {
            kisiler = new List<Kisi>
        {
            new Kisi("Ali", "Veli", "1234567890"),
            new Kisi("Ayşe", "Fatma", "0987654321"),
            new Kisi("John", "Doe", "1122334455"),
            new Kisi("Jane", "Doe", "2233445566"),
            new Kisi("Tom", "Jerry", "3344556677")
        };
        }

        public void NumaraKaydet(string isim, string soyisim, string telefonNumarasi)
        {
            kisiler.Add(new Kisi(isim, soyisim, telefonNumarasi));
        }

        public void NumaraSil(string isim, string soyisim)
        {
            var kisi = kisiler.FirstOrDefault(k => k.Isim == isim || k.Soyisim == soyisim);
            if (kisi != null)
            {
                kisiler.Remove(kisi);
                Console.WriteLine($"{kisi.Isim} isimli kişi rehberden silindi.");
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.");
            }
        }

        public void NumaraGuncelle(string isim, string soyisim, string yeniTelefonNumarasi)
        {
            var kisi = kisiler.FirstOrDefault(k => k.Isim == isim || k.Soyisim == soyisim);
            if (kisi != null)
            {
                kisi.TelefonNumarasi = yeniTelefonNumarasi;
                Console.WriteLine($"{kisi.Isim} isimli kişinin numarası güncellendi.");
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.");
            }
        }

        public void RehberiListele(bool alfabetikSirayaGore = true)
        {
            var siraliKisiler = alfabetikSirayaGore ? kisiler.OrderBy(k => k.Isim).ToList() : kisiler.OrderByDescending(k => k.Isim).ToList();
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach (var kisi in siraliKisiler)
            {
                Console.WriteLine($"İsim: {kisi.Isim}, Soyisim: {kisi.Soyisim}, Telefon Numarası: {kisi.TelefonNumarasi}");
            }
        }

        public void RehberdeAra(string aramaKriteri, bool isimVeSoyisimeGore = true)
        {
            var aramaSonucu = isimVeSoyisimeGore
                ? kisiler.Where(k => k.Isim.Contains(aramaKriteri) || k.Soyisim.Contains(aramaKriteri)).ToList()
                : kisiler.Where(k => k.TelefonNumarasi.Contains(aramaKriteri)).ToList();

            if (aramaSonucu.Any())
            {
                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");
                foreach (var kisi in aramaSonucu)
                {
                    Console.WriteLine($"İsim: {kisi.Isim}, Soyisim: {kisi.Soyisim}, Telefon Numarası: {kisi.TelefonNumarasi}");
                }
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.");
            }
        }
    }
}
