using Custom_Attribute_Ödevi.@class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Attribute_Ödevi
{
    public static class Validator
    {
        public static List<string> Dogrula(object obj)
        {
            List<string> hatalar = new List<string>();
            var properties = obj.GetType().GetProperties();

            foreach (var prop in properties)
            {
                var attr = (ZorunluAlanAttribute)Attribute.GetCustomAttribute(prop, typeof(ZorunluAlanAttribute));
                if (attr != null)
                {
                    var deger = prop.GetValue(obj) as string;
                    if (string.IsNullOrWhiteSpace(deger))
                    {
                        hatalar.Add(attr.HataMesaji);
                    }
                }
            }

            return hatalar;
        }
    }
}
