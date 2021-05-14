using System.Collections.Generic;

namespace PierresVendorApp.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; }
    public int Id { get; }
    private static int _idCounter = 0;
    private static List<Vendor> _vendors = new List<Vendor>();
    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order>();
      _idCounter += 1;
      Id = _idCounter;
      _vendors.Add(this);
    }

    public static List<Vendor> GetAllVendors()
    {
      return _vendors;
    }

    public static Vendor FindById(int id)
    {
      return _vendors.Find(vendor => vendor.Id == id);
    }

    public static void ClearAll()
    {
      _vendors.Clear();
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

  }
}
