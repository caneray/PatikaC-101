using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class TakimUyesi
    {
        public int Id { get; set; }
        public string Isim { get; set; }

        public TakimUyesi(int id, string isim)
        {
            Id = id;
            Isim = isim;
        }
    }
}
