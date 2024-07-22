using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Casting_Operator.NewFolder
{
    internal class EmployeeView
    {
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }

        public static explicit operator EmployeeView(Employee e)
        {
            string[] Names = e?.FullName?.Split(' ') ?? [""];
            return new EmployeeView()
            {
                Fname = Names[0]??" ",
                Lname = Names[1]??" ",
                Email = e?.Email ?? string.Empty,
                ID = e?.ID ?? 0,
            };
        }
    }
}
