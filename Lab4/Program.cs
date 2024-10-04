using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, IBeverage> beverageList = BeverageFactory.CreateBeverages();
            Dictionary<int, ICondiment> condimentList = CondimentFactory.CreateCondiments();

            Console.WriteLine("Select the beverage: ");
            Console.WriteLine("1. Coffee ($2.00)");
            Console.WriteLine("2. Espresso ($2.50)");
            Console.WriteLine("3. Latte ($3.00)");

           
            int beverageIndex = Convert.ToInt32(Console.ReadLine());
            string details = "";
            decimal totalPrice = 0.00m;  

            switch (beverageIndex)
            {
                case 1:
                    details = beverageList[1].AddBeverage("");
                    totalPrice += beverageList[1].GetPrice();  
                    break;
                case 2:
                    details = beverageList[2].AddBeverage("");
                    totalPrice += beverageList[2].GetPrice();
                    break;
                case 3:
                    details = beverageList[3].AddBeverage("");
                    totalPrice += beverageList[3].GetPrice();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Exiting.");
                    return;
            }

            Console.WriteLine("Select the condiments for your beverage: ");
            Console.WriteLine("1. Milk ($0.50)");
            Console.WriteLine("2. Sugar ($0.25)");
            Console.WriteLine("3. Whipped Cream ($0.75)");
            Console.WriteLine("4. None");
            Console.WriteLine("5. Exit");

            while (true)
            {
                int condimentIndex = Convert.ToInt32(Console.ReadLine());

                switch (condimentIndex)
                {
                    case 1:
                        details = condimentList[1].AddCondiment(details);
                        totalPrice += condimentList[1].GetPrice();  
                        break;
                    case 2:
                        details = condimentList[2].AddCondiment(details);
                        totalPrice += condimentList[2].GetPrice();
                        break;
                    case 3:
                        details = condimentList[3].AddCondiment(details);
                        totalPrice += condimentList[3].GetPrice();
                        break;
                    case 4:
                        details = condimentList[4].AddCondiment(details);
                        break;
                    case 5:
                        Console.WriteLine(details);
                        Console.WriteLine($"Total Price: ${totalPrice:F2}");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid condiment.");
                        break;
                }

                Console.WriteLine("Would you like to add another condiment? (1-4 for more condiments, 5 to finish)");
            }
        }
    }
}
