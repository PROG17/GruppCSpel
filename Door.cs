using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpelGruppC1
{
    class Door
    {
        public bool Open = false;
        public bool Closed = true;
        public bool Locked = true;

        public Door(bool open, bool closed, bool locked)
        {
            Open = open;
            Closed = closed;
            Locked = locked;
        }
      
        public void OpenOrClosed()
        {
            if(Open)
            { Console.WriteLine("The door is open"); }
            else
            { Console.WriteLine("The door is closed"); }
        }

        public void IsLocked()
        {
            if(Locked)
            { Console.WriteLine("The Door is Locked"); }
            else
            { Console.WriteLine("The Door is not locked"); }
        }

        public void UnlockDoor(string key)
        {
            if (key == "blue key")
            { Console.WriteLine("You opened the door"); }
            else
            { Console.WriteLine("Wrong key"); }
        }
    }
}
