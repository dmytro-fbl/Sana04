using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTask
{
    public class Currency
    {
        protected string _name;
        protected double _exRate;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Назва грошової одиниці не може бути порожньою");
                _name = value;
            }
        }
        public double ExRate
        {
            get { return _exRate; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Курс валюти не може бути від'ємним");
                _exRate = value;
            }
        } 

        public Currency()
        {
            Name = "Гривня";
            ExRate = 1;
        }

        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }
        public Currency(string name)
        {
            Name = name;
        }
        public Currency(Currency origin)
        {
            Name = origin.Name;
            ExRate = origin.ExRate;
        }

    }
}
