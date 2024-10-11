using System;
using System.Collections.Generic;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleProduct laptop = new SimpleProduct("Gaming Laptop", "High-performance gaming laptop", 1200.00m);
            SimpleProduct mouse = new SimpleProduct("Gaming Mouse", "RGB gaming mouse", 60.00m);
            SimpleProduct headphones = new SimpleProduct("Headphones", "Wireless gaming headphones", 100.00m);
            SimpleProduct keyboard = new SimpleProduct("Keyboard", "Mechanical keyboard", 150.00m);
            SimpleProduct chocolates = new SimpleProduct("Chocolates", "Luxury chocolate box", 30.00m);
            SimpleProduct cake = new SimpleProduct("Cake", "Chocolate cake", 40.00m);
            Console.WriteLine(laptop.GetDetails());
            Console.WriteLine();

           
            Bundle gamingBundle = new Bundle("Gaming Setup", 15);
            gamingBundle.AddProduct(laptop);
            gamingBundle.AddProduct(mouse);
            gamingBundle.AddProduct(headphones);
            gamingBundle.AddProduct(keyboard);
            Console.WriteLine(gamingBundle.GetDetails());
            Console.WriteLine();

            
            Bundle giftBundle = new Bundle("Holiday Gift", 10);
            giftBundle.AddProduct(chocolates);
            giftBundle.AddProduct(cake);

            
            Bundle megaBundle = new Bundle("Mega Bundle", 5);
            megaBundle.AddProduct(gamingBundle);
            megaBundle.AddProduct(giftBundle);

            
            Console.WriteLine(megaBundle.GetDetails());
            Console.ReadKey();
        }
    }
}