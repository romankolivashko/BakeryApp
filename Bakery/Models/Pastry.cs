using System;
//using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    // properties, methods, etc. will go here.
    //private static List<Pastry> _instances = new List<Pastry> {};
    //public string Description { get; set;}
    public int PastryQuantity { get; set;}
    public int PastryCost { get; set;}
    public Pastry(int pastryQuantity, int pastryCost)
    {
      PastryQuantity = pastryQuantity;
      PastryCost = pastryCost;
    }

    public static int PastrySale(int pastryQuantity)
    {
      int finalPrice = (pastryQuantity * 2) - ((pastryQuantity / 3) * 1);
      return finalPrice;
    }

  }
    
}