using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Coffee : IBeverage
    {
        public string AddBeverage(string details)
        {
            return details + "Beverage: Coffee\n";
        }

        public decimal GetPrice()
        {
            return 2.00m;
        }
    }
}
