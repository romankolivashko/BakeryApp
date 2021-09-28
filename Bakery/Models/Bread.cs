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

    const int breadCost = 5;
    public int BreadSale(int breadQuantity)
    {
      int finalPrice = (breadQuantity * breadCost) - ((breadQuantity / 3) * breadCost);
      return finalPrice;
    }

  }
    
}