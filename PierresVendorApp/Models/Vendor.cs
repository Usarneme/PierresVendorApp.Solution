using System;

namespace PierresVendorApp.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public Vendor(string name)
    {
      Name = name;
    }
  }
}
