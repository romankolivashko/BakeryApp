using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Bread
  {
    // properties, methods, etc. will go here.
    private static List<Bread> _instances = new List<Bread> {};
    public string Description { get; set;}
    public int Quantity { get; set;}
    public int Cost { get; set;}

    public Bread(string description, int quant, int cost)
    {
      Description = description;
      Quantity = quant;
      Cost = cost;
    }

    public static void BreadCreate()
    {
      Bread wheat = new Bread("wheat", 0, 3);
      Bread white = new Bread("white", 0, 4);
      Bread rye = new Bread("rye", 0, 5);
      _instances.Add(wheat);
      _instances.Add(white);
      _instances.Add(rye);
    }


    public static List<Bread> GetAllBread()
    {
      return _instances;
    }

    public static void ClearBreadList()
    {
      _instances.Clear();
    }

    public static void DisplayBread()
    {
      for (int i = 0; i < Bread._instances.Count; i++)
      {
        if (Bread._instances[i].Quantity > 0)
        {
          Console.Write(Bread._instances[i].Description + " * " + Bread._instances[i].Quantity + ", ");
        }
      }
    }

    public static int BreadCount()
    {
      int finalCount = 0;
      for (int i = 0; i < Bread._instances.Count; i++)
      {
        finalCount += Bread._instances[i].Quantity;
      } 
      return finalCount;
    }

    public static int BreadPrice()
    {
      int finalPrice = (Bread.BreadCount() * 5) - ((Bread.BreadCount() / 3) * 5);
      return finalPrice;
    }

  }
    public class Pastry
  {
    // properties, constructors, methods, etc. go here
  }



}