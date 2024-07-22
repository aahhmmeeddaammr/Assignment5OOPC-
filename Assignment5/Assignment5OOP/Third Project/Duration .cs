using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5OOP.Third_Project
{
    internal class Duration :ICloneable  
    {
        #region Attrebutes and Propertes 
        private int seconds;
        private int minutes;
        private int hours;

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }
        #endregion

        #region Constructors
        public Duration(int _Hours, int _Minutes, int _Seconds)
        {
            if(_Hours < 0 || _Minutes < 0 || _Seconds < 0)
            {
                throw new ArgumentException("Invalid Time");
            } 
            Hours = _Hours;
            Minutes = _Minutes;
            Seconds = _Seconds;
        
            Minutes += Seconds / 60;
            Seconds %= 60;
            Hours += Minutes / 60;
            Minutes %= 60;
        }
        public Duration() : this(0, 0, 0)
        {
        
        }
        public Duration(int _Seconds)
        {
            if ( _Seconds < 0)
            {
                throw new ArgumentException("Invalid Time");
            }
            int _hours = _Seconds / 3600;
            Hours = _hours;
            _Seconds %= 3600;
            Minutes = _Seconds / 60;
            Seconds = _Seconds % 60;
        }
        #endregion

        #region Override Methods
        public override bool Equals(object obj)
        {
            if (obj is Duration other)
            {
                return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            
            return $"Hours: {Hours}, Minutes : {Minutes}, Seconds : {Seconds}";
        }

        public object Clone()
        {
            return new Duration(Hours, Minutes, Seconds);
        }
        #endregion


        #region binary Operators Overloading
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(((d1?.Hours ?? 0) + (d2?.Hours ?? 0)), ((d1?.Minutes ?? 0) + (d2?.Minutes ?? 0)), ((d1?.seconds ?? 0) + (d2?.seconds ?? 0)));
        }
        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.Hours, d.Minutes, d.Seconds + seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return new Duration(d.Hours, d.Minutes, d.Seconds + seconds);
        }
        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(Math.Abs((d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) - (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds)));
        }
        #endregion


        #region Unary Operators OverLoading
        public static Duration operator ++(Duration d)
        {
            return new Duration(d.Hours, d.Minutes + 1, d.Seconds);
        }

        public static Duration operator --(Duration d)
        {
            if ((d?.Minutes ?? 0) != 0)
            {
                return new Duration(d?.Hours ?? 0, d?.Minutes ?? 0 - 1, d?.Seconds ?? 0);
            }
            if ((d?.Hours ?? 0) != 0)
            {

                return new Duration(d?.Hours ?? 0 - 1, 59, d?.Seconds ?? 0);
            }
            throw new ArgumentException("Can not do this operation");
        }

        #endregion


        #region comparison Operators Overloading
        public static bool operator >(Duration d1, Duration d2)
        {
            return (((d1?.Hours ?? 0) * 3600) + ((d1?.Minutes ?? 0) * 60) + (d1?.Seconds ?? 0)) > (((d2?.Hours ?? 0) * 3600) + ((d2?.Minutes ?? 0) * 60) + (d2?.Seconds ?? 0));
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return (! (d1 > d2) )&&  ! (d1.Equals(d2));
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return (d1>d2) || (d1.Equals(d2));
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return (d1<d2) || (d1.Equals(d2));
        }
        #endregion


        #region Casting OverLoading
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d?.Hours ?? 0, d?.Minutes ?? 0, d?.Seconds ?? 0);
        } 
        #endregion

       
        
    }
}
