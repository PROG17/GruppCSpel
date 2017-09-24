using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpelGruppC1
{
    public class Room
    {
        public string RoomSize { get; set; }
        public int NumberOfDoors { get; set; }
        public string Furniture { get; set; }

        public Room(string roomSize, int numberOfDoors, string furniture)
        {
            RoomSize = roomSize;
            NumberOfDoors = numberOfDoors;
            Furniture = furniture;
        }
    }
}
