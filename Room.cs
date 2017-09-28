using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpelGruppC1
{
    public abstract class Room
    {
        
        public int NumberOfDoors { get; set; }
       

        public Room(int numberOfDoors)
        {
           
            NumberOfDoors = numberOfDoors;
            
        }

        public virtual void PrintDescription()
        {
            Console.WriteLine("du står i ett mörkt rum");
        }
    }
}
