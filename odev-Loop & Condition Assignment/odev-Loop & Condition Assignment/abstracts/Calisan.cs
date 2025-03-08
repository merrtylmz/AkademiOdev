using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace odev_Loop___Condition_Assignment.abstracts
{
    public abstract class Calisan
    {
        public abstract int MaasToplamı();
        public void CalisanBilgileri(string ad, string soyad, string departman, int maas)
        {
            Console.WriteLine("{0} {1} {2} {3}  ",ad,soyad,departman,maas);
        }
        
    }
}
