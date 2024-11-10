using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BYT_project
{
    class Room
    {
        private int number;
        enum RoomType {
            Vip,
            Regular
        }
        enum RoomStaus {
            Taken,
            Free
        }
        private RoomType type;
        private int price;
        private RoomStaus staus;

        public int GetPrice()  {
            return price;
        }

        public static TimeOnly cleaningHours;

        public Room(int num, string type, int price, string status, string hours) { 

            this.number = num;
            this.price = price;

            switch (type) {
                case "Vip":
                    this.type = RoomType.Vip;
                    break;
                case "Regular":
                    this.type=RoomType.Regular;
                    break;
            }

            switch (type) {
                case "Taken":
                    this.staus = RoomStaus.Taken;
                    break;
                case "Free":
                    this.staus=RoomStaus.Free;
                    break;  
            }

            if (TimeOnly.TryParse(hours, out Room.cleaningHours))
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
