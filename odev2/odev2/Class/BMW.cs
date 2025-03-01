using odev2.Abstracts;
using odev2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2.Class
{
    class BMW:Car, Iucmak, Iyuzmek, Ihiz
    {
        

        public void hiz()
        {
            Console.Write("çok hızlı gider");
        }
        public void yuz()
        {
            Console.Write(",denizde yüzer");    
        }
        public void uc()
        {
            Console.WriteLine(",havada uçar.");
        }

        
    }

   
}
