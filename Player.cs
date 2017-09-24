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
    

        public static string ChooseDirection()
        {
            Console.WriteLine("where do you want to go? \n {0} {1} {2} {3}", 
                               Direction.FORWARD, Direction.LEFT, 
                               Direction.RIGHT, Direction.BACK);
            string answer = Console.ReadLine();

            return answer;
        }

        public static void GoInDirection(string answer)
        {
            if (answer == "Go forward") {Console.WriteLine("You are going forward"); }
            else if (answer == "Go back") {Console.WriteLine("You are going back"); }
            else if (answer == "Go left") {Console.WriteLine("You are going left"); }
            else if (answer == "Go right"){ Console.WriteLine("You are going right"); }
        }
            
           
    }
}
