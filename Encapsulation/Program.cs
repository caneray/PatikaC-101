using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Encapsulation yani Kapsülleme kavramı bir özeliği başka sınıflardan saklamak ya da korumaktır.
             Örneğin siz bir propery yani özellik tanımı yaptınız ve diğer sınıflar içerisinden erişilsin ama 
             sadece okumak için erişilsin değeri dışarıdan değiştirilemesin istiyorsunuz. Bunu kapsülleme yaparak sağlayabilirsiniz. 
             Kapsülleme işlemini ise property leri kullanarak yapabilirsiniz.
             https://academy.patika.dev/tr/courses/csharp-101/3-encapsulation-ve-property-kavrami
             */

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Caner";
            ogrenci.Soyisim = "Ay";
            ogrenci.OgrenciNo = 428;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Çağla","Şılak",123,1);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string isim; //private değişkenler küçük harfle veya _ ile başlar. Yazım kuralıdır.
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim {  
            get => isim; //gette isimi döndürür.
            set => isim = value; //sette ismi value atar
        }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; } // Burada set fonksiyonunu sildiğimizde ogrenciNo sadece readonly olacak ve yukarıda değer ataması yapamayacaktık.
        public int Sinif 
        { 
            get => sinif;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf En az 1 olabilir.");
                    sinif = 1;

                }
                else
                    sinif = value;
            }
        } 

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci() { }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("********************* Ogrenci Bilgileri *****************");
            Console.WriteLine("İsim : {0}", this.Isim);
            Console.WriteLine("Soyisim : {0}", this.Soyisim);
            Console.WriteLine("Ogrenci No : {0}", this.OgrenciNo);
            Console.WriteLine("Sınıfı : {0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}
