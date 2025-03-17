using odev_Constructor___Composition___Overloading.classes;
using odev_Constructor___Composition___Overloading.Constructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_Constructor___Composition___Overloading
{
    class Program
    {
        static void Main(string[] args)
        {// 1- C#’ta Composition Kullanarak Araç Oluşturma
            //"Arabanın markası BMW, modeli X5, kapı sayısı 4, pencere sayısı 4, kasası sedan, fiyatı 2.000.000 TL’dir."

            Marka marka = new Marka("BMW");
            Model model = new Model("X5");
            Kasa kasa = new Kasa("sedan");

            Kapi kapi = new Kapi(4);
            Fiyat fiyat = new Fiyat(2000000);
            PencereSayisi pencereSayisi = new PencereSayisi(4);
            Yeniaraba yeniaraba = new Yeniaraba(new Car(marka, model, kasa, kapi, fiyat, pencereSayisi));
            yeniaraba.siparisVer();
            
            //2 - Method Overloading ile Matematik Sınıfı
            Matematik mat = new Matematik();

            Console.WriteLine("Topla (int a, int b): " + mat.Topla(3, 5));
            Console.WriteLine("Topla (int a, int b, int c): " + mat.Topla(3, 5, 7));
            Console.WriteLine("Topla (double a, double b): " + mat.Topla(3.5, 5.5));
            Console.WriteLine("Topla (double a, double b, double c): " + mat.Topla(3.5, 5.5, 7.5));


            Console.WriteLine("Carp (int a, int b ): " + mat.Carp(3, 5));
            Console.WriteLine("Carp (int a, int b, int c): " + mat.Carp(3, 5, 7));
            Console.WriteLine("Carp (double a, double b): " + mat.Carp(3.5, 5.5));
            Console.WriteLine("Carp (double a, double b, double c): " + mat.Carp(3.5, 5.5, 7.5));

        }
    }
}
