using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_project
{
    class Cleaner : Staff
    {
        private TimeOnly workingHours;
        enum CleanerType{
            Room_cleaner,
            Restaurant_cleaner,
            General_cleaner
        }
        private CleanerType type;
        public Cleaner(string name, int salary, string hours, string type) : base(name, salary)
        {
            if (TimeOnly.TryParse(hours, out this.workingHours))
            {
                Console.WriteLine("Successfully coverted " + hours);
            }
            else
            {
                Console.WriteLine("Couldn't convert " + hours);
                throw new Exception("Error when convering date to TimeOnly");
            }

            switch (type)
            {
                case "Restaurant cleaner":
                    this.type = CleanerType.Restaurant_cleaner;
                    break;
                case "General cleaner":
                    this.type = CleanerType.General_cleaner;
                    break;
                case "Room cleaner":
                    this.type = CleanerType.Room_cleaner;
                    break;
            }
        }
    }
}
