using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_BasitHesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İlk sayıyı giriniz?");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz?");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int islemNo;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("İşlem numarası giriniz: \n1-Toplama\n2-Çıkarma\n3-Çarpma\n4-Bölme");
                islemNo = Convert.ToInt32(Console.ReadLine());
                if (islemNo == 1 || islemNo == 2 || islemNo == 3 || islemNo == 4)
                {
 
                    if (islemNo == 1)
            
                    {
                        Console.WriteLine("Toplama işlemi sonucu: " + (sayi1 + sayi2));
                    }
                    else if (islemNo == 2)
                    {
                        Console.WriteLine("Çıkarma işlemi sonucu: " + (sayi1 - sayi2));
                    }
                    else if (islemNo == 3)
                    {
                        Console.WriteLine("Çarpma işlemi sonucu: " + (sayi1 * sayi2));
                    }
                    else if (islemNo == 4)
                    {
                        Console.WriteLine("Bölme işlemi sonucu: " + (sayi1 / sayi2));
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı işlem numarası girdiniz.");
                }
            }
           

        }
    }
}
