using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_project
{
    internal class Waiter : Staff
    {
        private TimeOnly workingHours;

        public Waiter(string name, int salary, String hours) : base(name, salary) {

            if (TimeOnly.TryParse(hours, out this.workingHours))
            {
                Console.WriteLine("Successfully coverted " + hours);
            }
            else
            {
                Console.WriteLine("Couldn't convert " + hours);
                throw new Exception("Error when convering date to TimeOnly");
            }
        }
    }
}
