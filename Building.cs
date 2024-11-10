using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_project
{
    class Building
    {
        private string location;
        private int totalNumberOfRooms;
        private List<Room> rooms = new List<Room>();



        Building(string loc, int num, params Room[] rooms) { 
            this.location = loc;
            this.totalNumberOfRooms = num;

            foreach (Room room in rooms)
            {
                this.rooms.Add(room);
            }
        }

        public void addRoom(Room room) { 
            rooms.Add(room);
        }


    }
}
