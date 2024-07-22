using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal abstract class RectBase : Shape
    {
        

        public override double CalcArea()
        {
            return d1 * d2;
        }
    }
}
