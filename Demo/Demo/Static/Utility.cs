using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Static
{
    internal static class Utility
    {
        //public int X { get; set; }
        //public int Y { get; set; }

        private const double PI = 3.14;

        public static double pi { get; set; }

        static Utility()
        {
            pi = 3.14;
        }
        //public override string ToString()
        //{
        //    return $" {X} , {Y}";
        //}
        public static double CmToInch(double cm)
        {
            return cm * 2.54;

        }
        public static double CalcCircleArea(double rd)
        {
            return rd * PI* rd;

        }

    }
}
