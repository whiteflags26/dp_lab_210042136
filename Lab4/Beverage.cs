using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IBeverage
    {
        string AddBeverage(string details);
        decimal GetPrice();
    }
}
