using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal class Rectangle : RectBase
    {
        public override double Perimiter 
        { 
            get
            {
                return (d1 + d2) * 2;
            } 
        }

        public override double CalcArea()
        {
            return d1 * d2;
        }

    }
}
