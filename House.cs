using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpelGruppC1
{
    public class House
    {
        
        string houseType;
        int numberOfDoors;
        int numberOfRooms;

        public House (string houseType, int numberOfDoors, int numberOfRooms)
        {
            this.houseType = houseType;
            this.numberOfDoors = numberOfDoors;
            this.numberOfRooms = numberOfRooms;
        }

        public virtual void HouseStoryLine(Player player)
        {
            Console.WriteLine("You are standing in the hallway, in front of you there are {0} doors", numberOfDoors);
            player.ChooseDirection(); 
            Console.ReadLine();
        }
                     
    }
}
