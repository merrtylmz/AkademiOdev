using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Generic_List_ve_Nesne_Kullanımı_Ödevi___PRS.classes
{
    internal class car
    {
        public string Marka;
        public string Model;
        public double FuelConsumption;
        public double TotalDistance;

        public car(string marka, string model, double Fuelconsumption, double Totaldistance)
        {
            Marka = marka;
            Model = model;
            FuelConsumption = Fuelconsumption;
            TotalDistance = Totaldistance;
        }

        public double hesapla()
        {
            return (TotalDistance / 100) * FuelConsumption;
        }

        

    }
}
