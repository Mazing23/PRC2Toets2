using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC2Toets2
{
    [Serializable]
    public class SimpleDate
    {
        private DateTime date;

        public SimpleDate(int day, int month, int year)
        {
            date = new DateTime(year, month, day);
        }

        public int Day
        {
            get { return date.Day; }
        }

        public int Month
        {
            get { return date.Month; }
        }

        public int Year
        {
            get { return date.Year; }
        }

        public int DaysDifference(SimpleDate date)
        {
            TimeSpan timespan = date.date.Subtract(this.date);
            return timespan.Days;
        }

        public override string ToString()
        {
            return date.ToString("dd-MM-yyyy");
        }
    }
}
