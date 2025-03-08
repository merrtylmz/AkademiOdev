using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_Loop___Condition_Assignment.classes
{
    class arabaYasi
    {
        public void arabayasi() 
        {
            Console.WriteLine("Lütfen aracınızın yaşını giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            if (yas > 0 && yas < 10)
            {
                Console.WriteLine("Arabanız yeni");
            }
            else if (yas > 10 && yas < 20)
            {
                Console.WriteLine("Servise götürmeniz gerekebilir");
            }
            else if (yas > 20 && yas < 30)
            {
                Console.WriteLine("Arabanız hurdaya çıkabilir");
            }
            else
            {
                Console.WriteLine("Ya hiç üretilmedi ya da trafikten men edilmiştir");
            }
        }
    }
}
