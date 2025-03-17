using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_Constructor___Composition___Overloading.Constructors
{
    public class Car
    {
        public Marka marka;
        public Model model;
        public Kasa kasa;
        public Kapi kapi;
        public Fiyat fiyat;
        public PencereSayisi pencereSayisi;

        public Car(Marka marka, Model model, Kasa kasa, Kapi kapi, Fiyat fiyat,PencereSayisi pencereSayisi)
        {
            this.marka = marka;
            this.model = model;
            this.kasa = kasa;
            this.kapi = kapi;
            this.fiyat = fiyat;
            this.pencereSayisi = pencereSayisi;
        }
    }
}
