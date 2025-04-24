using odev_2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace odev_2.classes
{
    public class KrediKartı: IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"Ödeme Kredi Kartı ile yapıldı";
        }
    }
    
}
