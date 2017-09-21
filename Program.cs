using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpelGruppC1
{
    class Program
    {
        static void Main(string[] args)
        {
            House brandStation = new House("Brandstation", "röd");

            Console.WriteLine(brandStation.HouseType + " " + brandStation.HouseColor);
            Console.ReadLine();
        }
    }

}



