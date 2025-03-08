using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_Loop___Condition_Assignment.classes
{
    class yas
    {
        public void yasHesapla()
        {
            Console.WriteLine("Lütfen yaşınızı giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            if (yas > 0 && yas < 18)
            {
                Console.WriteLine("Küçüksünüz");
            }
            else if (yas >18 && yas<35)
            {
                Console.WriteLine("Gençsiniz");
            }
            else if (yas > 35 && yas < 55)
            {
                Console.WriteLine("Yetişkinsiniz");
            }
            else if (yas > 55 && yas < 75)
            {
                Console.WriteLine("Yaşlısınız");
            }
            else 
            {
                Console.WriteLine("Ya hiç doğmadınız ya da çoktan öldünüz...");
            }
            
        }
    }
}
