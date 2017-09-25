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

            hus.HouseStoryLine(player);
            

            Console.ReadLine();
          
        }
    }

}



