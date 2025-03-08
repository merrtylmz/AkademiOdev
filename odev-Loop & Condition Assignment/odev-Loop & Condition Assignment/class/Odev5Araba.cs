using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_Loop___Condition_Assignment.classes
{
    public class Araba
    {
        public string Marka;
        public double BenzinTuketimi;
        public int Model;

        public Araba(string marka, double benzinTuketimi, int model)
        {
            Marka = marka;
            BenzinTuketimi = benzinTuketimi;
            Model = model;
        }

        public void TuketimBilgisiYazdir()
        {
            Console.WriteLine("{0} :{1}  ", Marka, BenzinTuketimi);
        }
    }
}