using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehberApp
{
    public class Kisi
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TelefonNumarasi { get; set; }

        public Kisi(string isim, string soyisim, string telefonNumarasi)
        {
            Isim = isim;
            Soyisim = soyisim;
            TelefonNumarasi = telefonNumarasi;
        }
    }
}
