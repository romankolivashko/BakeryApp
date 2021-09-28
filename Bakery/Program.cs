using System;
using Bakery.Models;

namespace Bakery.Models
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.Title = "ASCII Art";
            string title = @"
***********************************             
|W|e|l|c|o|m|e| |t|o|              
***********************************
|P|i|e|r|r|e|'|s| |B|a|k|e|r|y|!|!|
***********************************                        
                                                                 ";
        Console.WriteLine(title);
        Console.WriteLine("*************");
        Console.WriteLine("Today On Sale:");
        Console.WriteLine("*************");
        Console.WriteLine("Buy 2, get 1 free");
        Console.WriteLine("(every 3rd loaf of bread is free.)");
        Console.WriteLine("***********************************");
        Console.WriteLine("A single loaf costs $5");
        Console.WriteLine("Two loaves          $10");
        Console.WriteLine("Three loaves        $10");
        Console.WriteLine("***********************");
        Console.WriteLine("\n");
        Console.WriteLine("CHECK OUT");
        Console.WriteLine("**********");
        Console.WriteLine("Would you like some bread? ");
        int quantInputB;
        Console.WriteLine("Enter number of loaves(if none, enter 0):");
        while (!int.TryParse(Console.ReadLine(), out quantInputB))
        {
          Console.Write("This is not a valid input.\n");
          Console.Write("Please enter an integer value: ");
        }
        System.Console.WriteLine("Confirmed! " + quantInputB + " loaves of bread.");
        Console.WriteLine("*****************************");
        Console.WriteLine("Would you like some pastry as well?");
        int quantInputP;
        Console.WriteLine("Enter number of pastries(if none, enter 0):");
        while (!int.TryParse(Console.ReadLine(), out quantInputP))
        {
          Console.Write("This is not a valid input.\n");
          Console.Write("Please enter an integer value: ");
        }
        System.Console.WriteLine("Confirmed! " + quantInputP + " piece(s) of pastry.");
        Console.WriteLine("********************************");
        Console.WriteLine("\n");
        Bread bread = new Bread(quantInputB, 0);
        Pastry pastry = new Pastry(quantInputP, 0);
        int breadSubtotal = Bread.BreadSale(quantInputB);
        int pastrySubtotal = Pastry.PastrySale(quantInputP);
        Console.WriteLine("Thank you! Your order is ready");
        Console.WriteLine("******************************");
        System.Console.WriteLine("Bread sub-total:           $" + breadSubtotal);
        System.Console.WriteLine("Pastry sub-total:          $" + pastrySubtotal); 
        Console.WriteLine("------------------------------");
        int total = breadSubtotal + pastrySubtotal;
        System.Console.WriteLine("Total:                     $" + total.ToString());
        Console.WriteLine("******************************");
        }
    }
}
