using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Trip
    {
        
    }

    public class BikeTrip : Trip
    { 
        public Rider Rider { get; set; }
        public Driver Driver { get; set; }
    }
}
