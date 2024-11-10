using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_project
{
    class CheckIn
    {
        private DateOnly date;
        private TimeOnly time;

        public DateOnly getCheckInDate() {
            return date;
        }
        public TimeOnly getCheckInTime()
        {
            return time;
        }

        public CheckIn(string date, string time) {
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
