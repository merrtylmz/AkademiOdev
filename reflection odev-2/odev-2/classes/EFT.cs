using odev_2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2.classes
{
    public class EFT :IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"Ödeme EFT ile yapıldı";
        }
    }
}
