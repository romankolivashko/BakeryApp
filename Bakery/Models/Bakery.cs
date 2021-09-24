using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Bread
  {
    // properties, methods, etc. will go here.
    private static List<Bread> _instances = new List<Bread> {};
    //public string Description { get; set;}
    public int Quantity { get; set;}
    public int Cost { get; set;}

    public Bread(int quant, int cost)
    {
      Quantity = quant;
      Cost = cost;
      _instances.Add(this);
    }

    public static void BreadCreate()
    {
      Bread bread = new Bread(1, 5);
      // Bread white = new Bread("white", 0, 4);
      // Bread rye = new Bread("rye", 0, 5);
      // _instances.Add(wheat);
      // _instances.Add(white);
      // _instances.Add(rye);
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
    //   int finalPrice = (Bread.BreadCount() * 5) - ((Bread.BreadCount() / 3) * 5);
    //   return finalPrice;
    // }

  }
    public class Pastry
  {
    // properties, constructors, methods, etc. go here
  }



}