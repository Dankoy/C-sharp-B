using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMade
{
    class DateObj
    {
        DateTime dateTime;
        public DateObj()
        {
            dateTime = new System.DateTime(DateTime.Now.Ticks);
            Console.WriteLine(dateTime);
        }

        public DateObj(string date)
        {
            dateTime = Convert.ToDateTime(date);
            Console.WriteLine(dateTime.ToShortDateString());
        }
        public DateObj(string date, string time)
        {
            Console.WriteLine(date + " " + time);
        }
    }
}
