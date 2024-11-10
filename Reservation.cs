using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BYT_project
{
    class Reservation
    {
        private int totalPrice;
        enum ResStatus { 
            Canceled,
            Confirmed
        }
        private ResStatus status;
        private int reservationDuration;
        private List<Room> reserverdRooms = new List<Room>();

        public Reservation(string status, DateOnly checkIn, DateOnly checkOut, params Room[] resRooms) {

            switch (status)
            {
                case "Canceled":
                    this.status = ResStatus.Canceled;
                    break;
                case "Confirmed":
                    this.status = ResStatus.Confirmed;
                    break;
            }

            this.reservationDuration = checkOut.DayNumber - checkIn.DayNumber;

            foreach (Room room in resRooms)
            {
                this.totalPrice += room.GetPrice();
            }
        }
    }
}
