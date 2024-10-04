using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class BeverageFactory
    {
        public static Dictionary<int, IBeverage> CreateBeverages()
        {
            Dictionary<int, IBeverage> beverageList = new Dictionary<int, IBeverage>();
            beverageList.Add(1, new Coffee());
            beverageList.Add(2, new Espresso());
            beverageList.Add(3, new Latte());

            return beverageList;
        }
    }
}
