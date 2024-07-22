using Demo.Abstraction;
using Demo.Casting_Operator;
using Demo.Casting_Operator.NewFolder;
using Demo.Operator_OverLoading;
using Demo.Partial;
using Demo.Static;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operators
            #region Main Variables
            //Complex c1 = new Complex()
            //{
            //    Real = 3,
            //    Image = 1
            //};
            //Complex c2 = new Complex()
            //{
            //    Real = 3,
            //    Image = 2
            //}; 
            #endregion

            #region Binary Operator
            //Complex c3 = c1 + c2;
            //c3 += c3;

            #endregion

            #region Unary Operator
            //Console.WriteLine(c1.GetHashCode());
            //Complex c4 = new Complex();
            //Console.WriteLine(c4.GetHashCode());

            //c4 = c1++;
            //Console.WriteLine(c4.GetHashCode());
            //Console.WriteLine(c1.GetHashCode());

            //Console.WriteLine(c4.GetHashCode());
            //Console.WriteLine(c2.GetHashCode());
            //c4 = ++c2;
            //Console.WriteLine(c4.GetHashCode());
            //Console.WriteLine(c2.GetHashCode());

            #endregion

            #region Comparision Operators
            //Console.WriteLine(c1 > c2);
            //Console.WriteLine(c1 < c2); 
            #endregion
            #endregion

            #region Casting Example
            Employee employee = new Employee()
            {
                ID = 1,
                FullName = "Ahmed Amr",
                Email = "aamr24987@gmail.com",
                Password = "/11/2/3.4//34#@343.4"
            };
            EmployeeView employee2 = (EmployeeView)employee;
            Console.WriteLine(employee2.ID);
            Console.WriteLine(employee2.Fname);
            Console.WriteLine(employee2.Lname);
            Console.WriteLine(employee2.Email);
            #endregion

            #region Abstraction
            //Shape rec = new Rectangle()
            //{
            //    d1 = 1,
            //    d2 = 10,
            //};
            //Console.WriteLine(rec.CalcArea()); 
            #endregion

            #region Static
            //Console.WriteLine(Utility.CmToInch(10));
            //Console.WriteLine(Utility.CalcCircleArea(10)); 
            #endregion

            Person person = new Person()
            {
                Id = 1,
                Age = "1",
                Name = "Test",
                Salary = 11
            };



        }
    }
}
