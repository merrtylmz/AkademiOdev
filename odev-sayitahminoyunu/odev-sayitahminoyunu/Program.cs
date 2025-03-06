using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_sayitahminoyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı tahmin oyununa hoşgeldiniz!");
            Random rnd = new Random();
            
            int sayi = rnd.Next(1, 100);
            int tahmin = 0;
            int hak = 10;
            
            while (hak > 0)
            {
                Console.WriteLine("Bir sayı giriniz:");
                tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin == sayi)
                {
                    Console.WriteLine("Tebrikler! Sayıyı doğru tahmin ettiniz.");
                    break;
                }
                else if (tahmin < sayi)
                {
                    Console.WriteLine("Daha büyük bir sayı giriniz.");
                }
                else
                {
                    Console.WriteLine("Daha küçük bir sayı giriniz.");
                }
                hak--;
                Console.WriteLine("Kalan hakkınız: " + hak);
            }
        }
    }
}
