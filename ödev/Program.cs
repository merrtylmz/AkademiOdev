using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            bmw araba = new bmw();
            araba.bilgi("bmw","düz");
            Porche araba1 = new Porche();
            araba1.bilgi("Porche", "otomatik");
            TOGG araba2 = new TOGG();
            araba2.bilgi("TOGG", "otomatik");
            mercedes araba3 = new mercedes();
            araba3.bilgi("mercedes", "düz");
            Console.ReadLine();

        }
    }
}
