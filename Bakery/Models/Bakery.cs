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
      //int finalPrice = (int)Math.Ceiling((int)breadQuantity / 3 * 2.0);
      //int finalPrice = (breadQuantity / 3 ) * 2 + breadQuantity % 3;
      return finalPrice;
    }


    public static List<Bread> GetAllBread()
    {
      return _instances;
    }

    public static void ClearBreadList()
    {
      _instances.Clear();
    }

    // public static int BreadPrice()
    // {
    //   int finalPrice = (Quantity * 5) - ((Quantity / 3) * 5);
    //   return finalPrice;
    // }

  }
    public class Pastry
  {
    // properties, constructors, methods, etc. go here
  }



}