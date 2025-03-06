using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev4_DizilerveDonguler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet sayı gireceksiniz?");
            int adet = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[adet];
            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz:", i + 1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());

            }


            Console.WriteLine("Ortalama: {0}", sayilar.Sum()/adet);

        }
    }
}
