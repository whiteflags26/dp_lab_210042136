using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WhippedCream : ICondiment
    {
        public string AddCondiment(string details)
        {
            return details + "Condiment: Whipped Cream\n";
        }

        public decimal GetPrice()
        {
            return 0.75m;
        }
    }
}
