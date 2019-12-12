using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Flight
    {
        public string city1 {get; set;}
        public string city2 {get; set;}
        public int year {get; set;}
        public float fare {get; set;}
        public float passengers { get; set; }
        public int nsmiles {get; set;}

        public Flight()
        {
            city1 = "";
            city2 = "";
            year = 0;
            fare = 0;
            passengers = 0;
            nsmiles = 0;
        }
          
        public override string ToString()
        {
            return city1 + '\n' + city2 + '\n' + year + '\n' + fare + '\n' + passengers + '\n' + nsmiles;
        }
    }
}
