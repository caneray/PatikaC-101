using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class Kart
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public TakimUyesi AtananKisi { get; set; }
        public KartBuyuklugu Buyukluk { get; set; }
        public string Line { get; set; }

        public Kart(string baslik, string icerik, TakimUyesi atananKisi, KartBuyuklugu buyukluk, string line)
        {
            Baslik = baslik;
            Icerik = icerik;
            AtananKisi = atananKisi;
            Buyukluk = buyukluk;
            Line = line;
        }
    }
}
