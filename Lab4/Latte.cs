using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Latte : IBeverage
    {
        public string AddBeverage(string details)
        {
            return details + "Beverage: Latte\n";
        }

        public decimal GetPrice()
        {
            return 3.00m;
        }
    }
}
