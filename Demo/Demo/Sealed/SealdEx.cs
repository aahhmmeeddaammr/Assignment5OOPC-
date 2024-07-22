using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed
{
     sealed class Payment
    {
        public /*virtual*/ void  proccesspayment(int amount )
        {
            Console.WriteLine($"Done {amount *10}");
        }
    }
    //class inheretPayment : Payment
    //{
    //    public override void proccesspayment(int amount )
    //    {
    //        Console.WriteLine($"Done {amount *140}");
    //    }
    //}
    internal class Parent
    {
        public virtual void print()
        {
            Console.WriteLine("Iam Parent");
        }

    }
    class Child: Parent {
        public sealed override void print()
        {
            Console.WriteLine("Iam child");
        }
    }
    sealed class  GrandChild : Child { }

    //class Test : GrandChild { } Cant Inheret 
}
