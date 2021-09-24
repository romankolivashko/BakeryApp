using System;

namespace Bakery.Models
{
  public class Bread
  {
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