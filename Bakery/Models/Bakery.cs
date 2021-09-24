using System.Collections.Generic;

namespace Bakery
{
  public class Bread
  {
    // properties, methods, etc. will go here.
    public string Description { get; set;}
    private static List<Bread> _instances = new List<Bread> {};

    public Bread(string description)
    {
      Description = description;
      _instances.Add(this);
    }

    public static List<Bread> GetAll()
    {
      return _instances;
    }

  }
    public class Pastry
  {
    // properties, constructors, methods, etc. go here
  }



}