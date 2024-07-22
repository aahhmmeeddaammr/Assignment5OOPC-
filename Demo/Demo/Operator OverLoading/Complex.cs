using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operator_OverLoading
{
    internal class Complex
    {
        public int Real { get; set; }
        
        public int Image { get; set; }

        public override string ToString()
        {
            return $"{Real } + {Image}i";
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) + (b?.Real ?? 0),
                Image = (a?.Image ?? 0) + (b?.Image ?? 0),
            };
        }
       
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) - (b?.Real ?? 0),
                Image = (a?.Image ?? 0) - (b?.Image ?? 0),
            };
        }
        
        public static Complex operator ++(Complex a)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) +1 ,
                Image = (a?.Image ?? 0) ,
            };
        }
       
        public static Complex operator --(Complex a)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) -1 ,
                Image = (a?.Image ?? 0)  ,
            };
        } 
       
        public static bool operator <(Complex a , Complex b)
        {
            return (a?.Real ?? 0) < (b?.Real ?? 0) || (a?.Image ?? 0) < (b?.Image ?? 0);
        }
       
        public static bool operator >(Complex a , Complex b)
        {
            return (a?.Real ?? 0) > (b?.Real ?? 0) || (a?.Image ?? 0) > (b?.Image ?? 0);
        }
        
        public static  explicit operator int(Complex a)
        {
            return a?.Real??0;
        }
        
        public static  explicit operator string(Complex a)
        {
            return a?.ToString()??"";
        }
    }
}
