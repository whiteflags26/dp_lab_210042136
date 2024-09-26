using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rider rider = new Rider();

            Console.WriteLine("Enter Rider's Name:");
            rider.Name = Console.ReadLine();

            Console.WriteLine("Choose options:");
            Console.WriteLine("1. Make Trip");
            Console.WriteLine("2. Exit");
            Console.WriteLine("Making Trip");

            Driver driver = new Driver();
            driver.Name = Console.ReadLine();


        }
    }
}
