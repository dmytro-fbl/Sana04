using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTask
{
    public class MyDate
    {
        protected int _year;
        protected int _month;
        protected int _day;
        protected int _hours;
        protected int _minutes;
        protected int Year
        {
            get {  return _year; }
            set
            {
                if (value < 2025)
                    throw new ArgumentOutOfRangeException(nameof(Year), "Рік заїзду не може бути менше 2025 року");
                _year = value;
            }
        }
        protected int Month
        {
            get { return _month; }
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentOutOfRangeException(nameof(Month), "Місяць не може бути менше 1 або більше 12");
                _month = value;
            }
        }
        protected int Day
        {
            get { return _day; }
            set
            {
                if(value < 1 || value > 31)
                {
                    throw new ArgumentOutOfRangeException(nameof(Day), "Місяць не може бути менше 1 або більше 31");
                }
                _day = value;
            }
        }
        protected int Hours
        {
            get { return _hours; }
            set
            {
                if (value < 0 || value > 24)
                    throw new ArgumentOutOfRangeException(nameof(Hours), "Годин не можуть бути менше 0 або більше 24");
                _hours = value;
            }
        }
        protected int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value < 0 || value > 60)
                    throw new ArgumentOutOfRangeException(nameof(Minutes), "Хвилин не може бути менше 0 або більше 60");
                _minutes = value;
            }
        }

        public MyDate(int year, int month, int date, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = date;
            Hours = hours;
            Minutes = minutes;
        }
        public MyDate(int year, int month, int date)
        {
            Year = year;
            Month = month;
            Day = date;
        }
        public MyDate(MyDate original)
        {
            Year = original.Year;
            Month = original.Month;
            Day = original.Day;
            Hours = original.Hours;
            Minutes = original.Minutes;
        }
        public MyDate()
        {
            Year = 2025;
            Month = 1;
            Day = 1;
            Hours = 0;
            Minutes = 0;
        }

        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day, Hours, Minutes, 0);
        }
        
    }
   
}
