using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpelGruppC1
{
    public class Player
    {
        string[] inventory = { "Letter", "Blue Key", "Hammer" };  //man ska kunna titta i inventory och ta ut/lägga till/ saker.    
        public enum Direction { BACK, FORWARD, LEFT, RIGHT };

        public Player(){}
        public string Name { get; set; }
        public string[] Inventory { get; set; }

        public void ShowInventory()
        {
            foreach(string item in inventory)
            {
                Console.Write(item + ", ");
            }
        }
        public void ChooseForwardLeft()
        {
            Console.WriteLine("where do you want to go? \n {0} {1}",
                               Direction.FORWARD, Direction.LEFT);
            string answer = Console.ReadLine();

            InFrontOfDoor(answer);
        }      
        public void ChooseForwardRight()
        {
            Console.WriteLine("where do you want to go? \n {0} {1}",
                               Direction.FORWARD, Direction.RIGHT);
            string answer = Console.ReadLine();

            InFrontOfDoor(answer);
        }
        public void ChooseForwardLeftRight()
        {
            Console.WriteLine("where do you want to go? \n {0} {1} {2}", 
                               Direction.FORWARD, Direction.LEFT, 
                               Direction.RIGHT);
            string answer = Console.ReadLine();

            InFrontOfDoor(answer);
        }
        public void ChooseForwardLeftRightBack()
        {
            Console.WriteLine("where do you want to go? \n {0} {1} {2} {3}",
                               Direction.FORWARD, Direction.LEFT,
                               Direction.RIGHT, Direction.BACK);
            string answer = Console.ReadLine();

            InFrontOfDoor(answer);
        }
        public virtual void InFrontOfDoor(string chosenDoor)
        {
            Door door1 = new Door(false, true, false, "the left door");
            Door door2 = new Door(false, true, true, "the middle door");
            Door door3 = new Door(false, true, true, "the right door");

            if (chosenDoor.ToLower().Contains("forward"))
            {
                Console.WriteLine("Your are standing in front of {0}", door2.location);
                Console.WriteLine("Do you want to try to open it? (y/n)");
                string answer = Console.ReadLine();
                if ((answer.ToLower() == "y"))
                {
                    door2.IsLocked();                  
                }

            }
            else if (chosenDoor.ToLower().Contains("right"))
            {
                Console.WriteLine("Your are standing in front of {0}", door3.location);
                Console.WriteLine("Do you want to try to open it? (y/n)");
                string answer = Console.ReadLine();
                if ((answer.ToLower() == "y"))
                {
                    door3.IsLocked();
                }

            }
            else if (chosenDoor.ToLower().Contains("left")) 
            {
                Console.WriteLine("Your are standing in front of {0}", door1.location);
                Console.WriteLine("Do you want to try to open it? (y/n)");
                string answer = Console.ReadLine();
                if ((answer.ToLower() == "y"))
                {
                    door1.IsLocked();
                }

            }
            else
            {
                Console.WriteLine("try again");
                //player.ChooseDirection();
            }

            

        }
        public void UseKey(string rightkey)
        {
            //    if(inventory.Contains("blue key"))
            //    {
            //        door2.UnlockDoor(inventory[/*lägg till nyckelns index]*/]);
            //    }
        }

        


    }
}
