using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpelGruppC1
{
    class Player
    {
        string Name { get; set; }
        public string[] inventory = { "Letter", "Blue Key", "Hammer" };  //man ska kunna titta i inventory och ta ut/lägga till/ saker.    

        public Player(string name)
        {
            Name = name;
        }
    }
}
