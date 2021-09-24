using System;

namespace Bakery.Models
{
  public class Pastry
  {
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