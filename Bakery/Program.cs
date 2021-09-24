using System;
using Bakery.Models;
//using Pastry.Models;

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
        int quantInputB = Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("You got it! " + quantInputB + " loaves of bread are coming up.");
        //Bread bread = new Bread(quantInput, 0);
        Console.WriteLine("Care for some pastry as well? If so, enter how many:");
        int quantInputP = Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("You got it! " + quantInputP + " piece(s) of pastry will be right up.");
        Bread bread = new Bread(quantInputB, 0);
        Pastry pastry = new Pastry(quantInputP, 0);
        int breadSubtotal = Bread.BreadSale(quantInputB);
        int pastrySubtotal = Pastry.PastrySale(quantInputP);
        //int Bread.BreadSale(quantInput);
        System.Console.WriteLine("-------------------------");
        System.Console.WriteLine("Bread sub-total:    $" + breadSubtotal);
        System.Console.WriteLine("Pastry sub-total:   $" + pastrySubtotal); 
        System.Console.WriteLine("-------------------------");
        int total = breadSubtotal + pastrySubtotal;
        System.Console.WriteLine("Total:              $" + total.ToString());
        // Bread bread = new Bread();
        // bread.GetAllBread();
        }
    }
}
