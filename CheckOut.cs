using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_project
{
    class CheckOut
    {
        private DateOnly date;
        private TimeOnly time;

        public DateOnly getCheckOutDate()
        {
            return date;
        }
        public TimeOnly getCheckoOutTime()
        {
            return time;
        }

        public CheckOut(string date, string time)
        {
            if (DateOnly.TryParse(date, out this.date))
            {
                Console.WriteLine("Successfully coverted " + date);
            }
            else
            {
                Console.WriteLine("Couldn't convert " + date);
                throw new Exception("Error when convering date to DateOnly");
            }

            if (TimeOnly.TryParse(time, out this.time))
            {
                Console.WriteLine("Successfully coverted " + time);
            }
            else
            {
                Console.WriteLine("Couldn't convert " + time);
                throw new Exception("Error when convering date to TimeOnly");
            }


        }
    }
}