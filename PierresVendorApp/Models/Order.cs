using System;

namespace PierresVendorApp.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public DateTime OrderPlacedDate { get; set; }
    public Order(string title, string description, int price, DateTime orderPlacedDate)
    {
      Title = title;
      Description = description;
      Price = price;
      OrderPlacedDate = orderPlacedDate;
    }
  }
}