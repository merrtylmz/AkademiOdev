using Generic_List_ve_Nesne_Kullanımı_Ödevi___PRS.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List_ve_Nesne_Kullanımı_Ödevi___PRS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<car> araba = new List<car>();

            araba.Add(new car("Bmw", "X5", 9.0, 450));
            araba.Add(new car("Toyota", "Corolla", 6.5, 325));
            araba.Add(new car("Mercedes", "C200", 8.2, 410));


            foreach (car car in araba)
            {
                double yakıtHesabı = car.hesapla();
                Console.WriteLine($"Marka: {car.Marka}, Model: {car.Model}, 100 km'de Yakıtı Yaktı: {car.FuelConsumption} litre, Toplam Yakıt Tüketimi: {yakıtHesabı} litre");
            }

            Console.ReadLine();



        }
    }
}
