using System.Collections.Generic;

namespace PierresVendorApp.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; }
    public int Id { get; }
    private static int IdCounter = 0;
    private static List<Vendor> _vendors = new List<Vendor>();
    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order>();
      IdCounter += 1;
      Id = IdCounter;
      _vendors.Add(this);
    }

    public static List<Vendor> GetAllVendors()
    {
      return _vendors;
    }
  }
}
