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
    const int pastryCost = 2;
    public static int PastrySale(int pastryQuantity)
    {
      int finalPrice = (pastryQuantity * pastryCost) - ((pastryQuantity / 3) * 1);
      return finalPrice;
    }

  }
    
}