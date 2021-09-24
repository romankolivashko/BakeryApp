using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    // properties, methods, etc. will go here.
    private static List<Bread> _instances = new List<Bread> {};
    //public string Description { get; set;}
    public int BreadQuantity { get; set;}
    public int BreadCost { get; set;}
    public Bread(int breadQuantity, int breadCost)
    {
      BreadQuantity = breadQuantity;
      BreadCost = breadCost;
    }

    public static int BreadSale(int breadQuantity)
    {
      int finalPrice = (breadQuantity * 5) - ((breadQuantity / 3) * 5);
      return finalPrice;
    }

  }
    
}