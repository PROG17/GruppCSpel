using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpelGruppC1
{
    public class GameRoom : Room
    {
        public string Description { get; set; }

        public GameRoom(int numberOfDoors, string description) : base(numberOfDoors)
        {
            Description = description;
        }

        public override void PrintDescription()
        {
            Console.WriteLine(Description);
        }
    }
}
