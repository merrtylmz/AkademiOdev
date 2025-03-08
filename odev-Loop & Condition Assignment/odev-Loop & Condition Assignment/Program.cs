
using odev_Loop___Condition_Assignment.abstracts;
using odev_Loop___Condition_Assignment.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace odev_Loop___Condition_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //odev-1. Ödev: Yaş Kategorisini Belirleme
            yas yasi = new yas();
            yasi.yasHesapla();

            //odev-2. Ödev: Araba Yaşı ve Durumu

            arabaYasi araba = new arabaYasi();
            araba.arabayasi();
            
            //odev-4.Ödev: Çalışanların Maaş Hesaplaması
            
            GenelMudur GM = new GenelMudur();
            Mudur MU = new Mudur();
            Programci PR = new Programci();
            Stajyer ST = new Stajyer();

            GM.CalisanBilgileri("Mert", "Yılmaz", "Genel Müdür", 75000);
            MU.CalisanBilgileri("Mert", "Yılmaz", "Müdür", 50000);
            PR.CalisanBilgileri("Mert", "Yılmaz", "Programcı", 25000);
            ST.CalisanBilgileri("Mert", "Yılmaz", "Stajyer", 10000);

            Double toplamMaas = GM.MaasToplamı() + MU.MaasToplamı() + PR.MaasToplamı() + ST.MaasToplamı();


            Console.WriteLine("Toplam Maaş: "+toplamMaas);


            //odev-5. Ödev: Arabaların Benzin Tüketimi
            Araba araba1 = new Araba("Audi", 5.5, 2021);
            Araba araba2 = new Araba("BMW", 6.2, 2019);
            Araba araba3 = new Araba("Mercedes", 7.1, 2018);
            
            araba1.TuketimBilgisiYazdir();
            araba2.TuketimBilgisiYazdir();
            araba3.TuketimBilgisiYazdir();
            





        }
    }
}
