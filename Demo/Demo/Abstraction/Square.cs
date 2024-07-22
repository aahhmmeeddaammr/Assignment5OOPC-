using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal class Square : RectBase
    {
        public Square(double d) {
            d1 = d2 = d;
        }
        public override double Perimiter
        {
            get
            { 
                return d2 * 4;
            }
        }

        public override double CalcArea()
        {
            return d1 * d2;
        }
    }
}
