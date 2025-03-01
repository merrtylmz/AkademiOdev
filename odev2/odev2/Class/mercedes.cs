using odev2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2.Class
{
    class mercedes : Car, Iucmak, Iyuzmek
    {
     

        public void yuz()
        {
            Console.Write( "Denizde yüzer");
        }
        public void uc()
        {
            Console.WriteLine( ",havada uçar.");
        }
       
    }
}
