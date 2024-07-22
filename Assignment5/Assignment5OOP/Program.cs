using Assignment5OOP.First_Project;
using Assignment5OOP.Second_Project;
using Assignment5OOP.Third_Project;
using System.Runtime.CompilerServices;

namespace Assignment5OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project
            #region Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).
            //Point3D p1 = new Point3D(10, 10, 10);
            //Point3D p2 = new Point3D(10, 10, 10);
            //for (int i = 0; i < 2; ) {
            //    int x, y, z;
            //    Console.WriteLine("Enter Point  :");
            //    do
            //    {
            //        Console.Write("X: ");

            //    } while (!int.TryParse(Console.ReadLine(), out x)); 
            //    do
            //    {
            //        Console.Write("Y: ");

            //    } while (!int.TryParse(Console.ReadLine(), out y)); 
            //    do
            //    {
            //        Console.Write("Z: ");

            //    } while (!int.TryParse(Console.ReadLine(), out z));
            //    if(i == 0)
            //    {
            //        p1 = new Point3D(x, y, z);
            //    }
            //    if(i == 1)
            //    {
            //        p2 = new Point3D(x, y, z);
            //    }
            //    i++;
            //}

            //if (p1 == p2)
            //{
            //    Console.WriteLine("P1 Equal P2");
            //}
            //else
            //{
            //    Console.WriteLine("P1 not Equal P2");
            //} 
            #endregion

            #region Define an array of points and sort this array based on X & Y coordinates.
            //Point3D[] points = {
            //    new Point3D (10, 10, 10),
            //    new Point3D (1,22,11),
            //    new Point3D (1,2,14),
            //    new Point3D (4,52,121),
            //    new Point3D (10,112,151),
            //    new Point3D (22,42,41),
            //};
            //Array.Sort(points);
            //for (int i = 0; i < points.Length; i++)
            //{
            //    Console.WriteLine($"\t{points[i]} ");
            //} 
            #endregion

            #region Implement ICloneable interface to be able to clone the object.
            //Point3D p1 = new Point3D(10,10,10); 
            //Point3D p2 = (Point3D) p1.Clone();

            //Console.WriteLine($"point 1 Hash Code = {p1.GetHashCode()}");
            //Console.WriteLine($"point 2 Hash Code = {p2.GetHashCode()}"); 
            #endregion
            #endregion


            #region Second Project
            //Console.WriteLine(Maths.Subtract(1, 2));
            //Console.WriteLine(Maths.Add(1, 2));
            //Console.WriteLine(Maths.Divide(1, 2));
            //Console.WriteLine(Maths.Multiply(1, 2)); 
            #endregion

            #region Define All Required Constructors to Produce this output:
            //Duration d = new Duration(1, 10, 11);
            //Duration d1 = new Duration(7800);
            //Duration d2 = new Duration(3600);
            //Duration d3 = new Duration(666);
            //Console.WriteLine(d);
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3); 
            #endregion

            Duration d = new Duration(1, 10, 11);
            Duration d1 = new Duration(7800);
            Duration d2 = new Duration(3600);

            //Duration d3 = d1+d2;
            //Console.WriteLine(d3);

            //d1 = ++d;
            //Console.WriteLine(d1);

            //d2 = --d;
            //Console.WriteLine(d2);

            //d3 = d1 - d2;
            //Console.WriteLine(d3);

            if (d1 > d2)
            {
                Console.WriteLine("d1>d2");
            }else if (d1 < d2)
            {
                Console.WriteLine("d1 < d2");
            }
            else
            {
                Console.WriteLine("d1 = d2");
            }

            DateTime dateTime = (DateTime)d1;
            Console.WriteLine(dateTime);
        }
    }
}
