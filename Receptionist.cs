using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_project
{
    internal class Receptionist : Staff
    {
        private TimeOnly workingHours;
        private List<Reservation> resList = new List<Reservation>();
        public Receptionist(string name, int salary, string hours) : base(name, salary) {
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

        private void addReservation(Reservation res)
        {
            resList.Add(res);
        }

        private void cancelReservation(int i) { 
            resList.RemoveAt(i);
        }
    }
}
