using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Sugar : ICondiment
    {
        public string AddCondiment(string details)
        {
            return details + "Condiment: Sugar\n";
        }

        public decimal GetPrice()
        {
            return 0.25m;
        }
    }
}
