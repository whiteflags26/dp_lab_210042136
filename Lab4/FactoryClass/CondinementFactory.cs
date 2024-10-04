using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class CondimentFactory
    {
        public static Dictionary<int, ICondiment> CreateCondiments()
        {
            Dictionary<int, ICondiment> condimentList = new Dictionary<int, ICondiment>();
            condimentList.Add(1, new Milk());
            condimentList.Add(2, new Sugar());
            condimentList.Add(3, new WhippedCream());
            condimentList.Add(4, new NoCondiment());

            return condimentList;
        }
    }
}
