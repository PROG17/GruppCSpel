using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpelGruppC1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Player player = new Player();
            House hus = new House("litet hus", 3, 3);
            GameRoom room1 = new GameRoom(3, "");
            GameRoom room4 = new GameRoom(3, "Find key in box");
            GameRoom room5 = new GameRoom(3, "Dark hallway, kill monster or be killed");
            GameRoom room3 = new GameRoom(3, "");
            GameRoom room2 = new GameRoom(3, "end room");


            //hus.HouseStoryLine(player);

            player.ShowInventory();
            

            Console.ReadLine();
          
        }
    }

}



