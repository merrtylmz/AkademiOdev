using odev2.Abstracts;
using odev2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2.Class
{
    class mercedesyakit:yakithesapla, IyakitHesapla
    {
        public void yakit()
        {
            throw new NotImplementedException();
        }

        public override double yakitHesaplama()
        {
            return 70;
        }
    }
    
}
