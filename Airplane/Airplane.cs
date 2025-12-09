using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneTask
{
    public class Airplane
    {

        protected string _startCity;
        protected string _finishCity;
        protected MyDate _startDate;
        protected MyDate _finishDate;
        public string StartCity
        {
            get { return _startCity; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Місто відправлення не може бути порожнім");
                _startCity = value;
            }
        }
        protected string FinishCity
        {
            get { return _finishCity; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Місто прибуття не може бути порожнім");
                _finishCity = value;
            }
        }
        protected MyDate StartDate {  get; set; }
        protected MyDate FinishDate { get; set; }

        public Airplane(string startC, string finishC, MyDate strartD, MyDate finishD)
        {
            StartCity = startC;
            FinishCity = finishC;
            FinishDate = finishD;
            StartDate = strartD;
        }
        public Airplane(string startC, string finishC)
        {
            StartCity = startC;
            FinishCity = finishC;
        }
        public Airplane(Airplane origin)
        {
            StartCity = origin.StartCity;
            FinishCity = origin.FinishCity;
            FinishDate = new MyDate (origin.FinishDate);
            StartDate = new MyDate(origin.StartDate);
        }
        public Airplane()
        {
            StartCity = "Невідомо";
            FinishCity = "Невідомо";
            StartDate = new MyDate();
            FinishDate = new MyDate();
        }

        public double GetTotalTime()
        {
            DateTime start = StartDate.ToDateTime();
            DateTime finish = FinishDate.ToDateTime();

            if(finish < start)
            {
                throw new ArgumentException("Дата виїзду не може бути рініше за дату заїзду");
            }
            TimeSpan totaltime = finish - start;

            return totaltime.TotalMinutes;
        }
        public bool IsArrivingToday()
        {
            
            if (StartDate.ToDateTime().Date == FinishDate.ToDateTime().Date)
            {
                return true;
            }
            return false;
        }
    }
}
