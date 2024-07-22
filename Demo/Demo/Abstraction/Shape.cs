using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal abstract class Shape
    {
        public double d1 { get; set; }
        public double d2 { get; set; }
        public abstract double Perimiter { get; }
        public abstract double CalcArea();
    }
}
