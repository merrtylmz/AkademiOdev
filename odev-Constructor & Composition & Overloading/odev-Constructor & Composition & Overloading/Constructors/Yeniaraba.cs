using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_Constructor___Composition___Overloading.Constructors
{
    public class Yeniaraba
    {
        public Car car;


        public Yeniaraba(Car car)
        {
            this.car = car;
        }
        public void siparisVer()
        {
            Console.WriteLine("Arabanın markası "+car.marka.markaAdi+
                " , modeli "+car.model.modelAdi+
                " , kapı sayısı " + car.kapi.kapiSayisi +
                " , pencere sayısı " + car.pencereSayisi.pencereSayisi +
                " , kasası " +car.kasa.kasaTipi+
                " , fiyatı "+car.fiyat.fiyatDegeri+
                " TL'dir.");
        }
    }
}
