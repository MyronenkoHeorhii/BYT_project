using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BYT_project
{
    class Restaurant
    {
        private TimeOnly openingTime;
        private TimeOnly closingTime;

        public Restaurant(string opTime, string closTime) {
            if (TimeOnly.TryParse(opTime, out this.openingTime))
            {
                Console.WriteLine("Successfully coverted " + opTime);
            }
            else
            {
                Console.WriteLine("Couldn't convert " + opTime);
                throw new Exception("Error when convering date to TimeOnly");
            }

            if (TimeOnly.TryParse(closTime, out this.closingTime))
            {
                Console.WriteLine("Successfully coverted " + closTime);
            }
            else
            {
                Console.WriteLine("Couldn't convert " + closTime);
                throw new Exception("Error when convering date to TimeOnly");
            }
        }
    }
}
