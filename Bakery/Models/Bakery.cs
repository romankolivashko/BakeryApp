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



  }
    public class Pastry
  {
    // properties, constructors, methods, etc. go here
  }



}