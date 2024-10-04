using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Espresso : IBeverage
    {
        public string AddBeverage(string details)
        {
            return details + "Beverage: Espresso\n";
        }

        public decimal GetPrice()
        {
            return 2.50m;
        }
    }
}
