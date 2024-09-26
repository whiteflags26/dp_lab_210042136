using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Driver
    {
        public string Name { get; set; }
        private string _id { get; set; }
        private string _location { get; set; }
        public decimal Rating { get; set; }
        public string Availabilty { get; set; }

        public void AcceptRide(Rider rider)
        {

        }

        public void PrintDriverinfo()
        {
            Console.WriteLine("Driver Name:" + Name);
        }
    }
}
