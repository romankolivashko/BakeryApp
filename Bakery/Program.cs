using System;
using Bakery.Models;

namespace Bakery.Models
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Welcome to Pierre's Bakery!!!");
        Console.WriteLine("We have on Sale Today:");
        Console.WriteLine("Buy 2, get 1 free (every 3rd loaf of bread is free.)");
        Console.WriteLine("A single loaf costs $5, two loaves cost $10, and three loaves cost $10.");
        Console.WriteLine("How many loaves of bread would you like to buy? Enter number:");
        int quant = Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("You got it! " + quant + " loaves of bread are coming up.");
        //Bread bread = new Bread(quantInput, 0);
        Console.WriteLine("Care for some pastry as well? If so, enter how many:");
        int quantInput = Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("You got it! " + quantInput + " piece(s) of pastry are coming up.");
        Bread bread = new Bread(quantInput, 0);
        //int Bread.BreadSale(quantInput);
        System.Console.WriteLine("-------------------------");
        System.Console.WriteLine("Bread total: " + Bread.BreadSale(quantInput));
        //System.Console.WriteLine("Your total is: " + bread.BreadSale);
        // Bread bread = new Bread();
        // bread.GetAllBread();
        }
    }
}
