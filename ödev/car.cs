using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ödev
{
    class car
    {
        public string marka;
        public string ozellik;

        public void bilgi(string markası,string ozelligi)
        {
            Console.WriteLine(markası+" "+ozelligi+" viteslidir");
            
        }

    }
}
