using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5OOP.First_Project
{
    internal class Point3D :IComparable , ICloneable
    {
        #region Attributes and Propertes
        private double x;

        private double y;

        private double z;

        public double Z
        {
            get { return z; }
            set { z = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        #endregion

        #region Constructors
        public Point3D(int _x, int _y, int _z)
        {
            X = _x;
            Y = _y;
            Z = _z;
        }
        public Point3D(int _x) : this(_x, 0, 0) { }

        public Point3D() : this(0) { }
        #endregion

        #region Ovveride Methods
        public override string ToString()
        {
            return $"Point Coordinates: ({this?.X ?? 0}, {this?.Y ?? 0}, {this?.Z ?? 0})";
        }

        public int CompareTo(object? obj)
        {
            if (obj != null)
            {
                Point3D temp = (Point3D)obj;
                if(this is not null)
                {
                    if (temp == this)
                    {
                        return 0;
                    }
                    
                    else if (this.X > temp.X || ((this.X == temp.X ) && this.Y > temp.Y) )
                    {
                        return 1;
                    }
                    return -1;
                }
                throw new ArgumentNullException(nameof(obj));
            }
            throw new ArgumentNullException(nameof(obj));
        }

        public object Clone()
        {
            return new Point3D
            {
                X=this.X,
                Y=this.Y,
                Z=this.Z
            };
        }
        #endregion

        #region Operator Overloading
        public static bool operator ==(Point3D a, Point3D b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }
        public static bool operator !=(Point3D a, Point3D b)
        {
            return !(a == b);
        }

        #endregion



    }
}
