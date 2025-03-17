using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_Constructor___Composition___Overloading.classes
{
    class Matematik
    {
        public int Topla(int a, int b)
        {
            return a + b;
        }
        public int Topla(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Topla(double a, double b)
        {
            return a + b;
        }
        public double Topla(double a, double b, double c)
        {
            return a + b + c;
        }
        public int Carp(int a, int b)
        {
            return a * b;
        }
        public int Carp(int a, int b, int c)
        {
            return a * b * c;
        }
        public double Carp(double a, double b)
        {
            return a * b;
        }
        public double Carp(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
