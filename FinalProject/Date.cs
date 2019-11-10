using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalProject
{
    [Serializable]
    public class Date
    {
        
        //properties
        private int day;
        public int Day
        {
            get { return day; }
            set {
                if (value >= 1 && value <= 31)
                    day = value;
                else
                    day = 1;              
            }
        }
        private int month;
        public int Month
        {
            get { return month; }
            set {
                if (value >= 1 && value <= 12)
                    month = value;
                else month = 1;              
            }
        }
        private int year;
        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 1800)
                    year = value;
                else
                    year = 2017;                    
            }
        }

        //ctors
        public Date() { }
        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        //methods
        public override String ToString()
        {
            return "\n" + this.Day + "/" + this.Month + "/" + this.Year;
        }
        public void Print(string str)
        {
            Console.WriteLine(str);
        }
        public bool Equals(Date d)
        {            
            return this.Day == d.Day && this.Month == d.Month && this.Year == d.Year;
        }
    }
}
