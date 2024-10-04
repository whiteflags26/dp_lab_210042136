using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NoCondiment : ICondiment
    {
        public string AddCondiment(string details)
        {
            return details;
        }

        public decimal GetPrice()
        {
            return 0.00m;
        }
    }
}
