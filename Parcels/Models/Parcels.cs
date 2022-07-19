using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    public string Weight { get; set; }
    public string Dimension { get; set; }
    private static List<Item> _instances = new List<Item> {};

    public Item (string description, string weight, string dimension)
    {
      Description = description;
      Weight = weight;
      Dimension = dimension;
      _instances.Add(this);
    }



    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}