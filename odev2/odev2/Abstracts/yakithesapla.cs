using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2.Abstracts
{
    public abstract class yakithesapla
    {
        public abstract double yakitHesaplama();

        public void Hesaplama(string isim)
        {
            Console.WriteLine(isim + "yakıt hesaplandı.");
        }
    }
}
