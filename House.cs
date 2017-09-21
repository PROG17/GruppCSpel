using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpelGruppC1
{
    class House
    {
        public string HouseType { get; set; }
        public string HouseColor { get; set; }

        public House(string houseType, string houseColor)
        {
            HouseType = houseType;
            HouseColor = houseColor;
        }
    }
}
