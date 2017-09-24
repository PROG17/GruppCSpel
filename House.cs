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

        public virtual void HouseStoryLine()
        {
            Console.WriteLine("You are standing in the hallway, in front of you there are {0} doors", numberOfDoors);
            Player.GoInDirection(Player.ChooseDirection()); //dessa är statiska metoder, bör ändras?
            Console.ReadLine();
        }

        public virtual void InFrontOfDoor()
        {
            Door door1 = new Door(false, true, false);

            Console.WriteLine("You are now standing in front of a door");
            Console.WriteLine("Do you want to try to open it? (y/n)");
            string answer = Console.ReadLine();
            if((answer.ToLower() == "y"))
            {
                //Door.IsLocked();
            }
        }

        

     
       
       

       
    }
}
