using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Sealed => Bir sınıfın başka sınıflar tarafından kalıtım vermesini engellemesini istiyorsak sealed kullanırız.
    // public sealed class Canlilar

    public  class Canlilar
    {
        protected void Beslenme(){
            Console.WriteLine("Canlılar Beslenir.");
        }

        protected void Solunum(){
            Console.WriteLine("Canlılar Solunum Yapar.");
        }
        protected void Bosaltim()
        {
            Console.WriteLine("Canlılar Boşaltım Yapar.");
        }
        public virtual void UyaranlaraTepki()  //geçiçi tanımalama virtual
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }
    }
}
