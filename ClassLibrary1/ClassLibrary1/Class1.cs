using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        int day;
        int month;
        int year;
        public int Day
        {
            get { return day; }
            set
            {
                if (value > 0 && value < 32)
                    day=value;
                else Console.WriteLine("Invalid Day");
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if (value > 0 && value < 13)
                     month=value;
                else Console.WriteLine("Invalid Month");
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value > 2017 || value < 2021)
                    year = value;
                else Console.WriteLine("Invalid YEAR");
            }
        }
    }
}
